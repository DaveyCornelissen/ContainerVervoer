using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainerVervoer.Models;

namespace ContainerTransport
{
    public class Logic
    {
        public Ship ship;

        public decimal DockedContainersWeight { get; set; }

        public List<Container> DockedContainers { get; set; } = new List<Container>();

        public Logic(decimal maxWeight)
        {
            ship = new Ship(maxWeight, 8);
        }

        /// <summary>
        /// Add a container to the docked containers list
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="standard"></param>
        /// <param name="valuable"></param>
        /// <param name="Cooled"></param>
        public void AddContainer(decimal weight, bool standard, bool valuable, bool Cooled)
        {
            Container newContainer = new Container
            {
                Weight = weight,
                Standard = standard,
                Valuable = valuable,
                Cooled = Cooled
            };

            DockedContainers.Add(newContainer);
            DockedContainersWeight += newContainer.Weight;
        }

        /// <summary>
        /// Remove a container from the docked containers
        /// </summary>
        /// <param name="index"></param>
        public void RemoveContainer(int index)
        {
            DockedContainersWeight -= DockedContainers[index].Weight;
            DockedContainers.RemoveAt(index);
        }

        /// <summary>
        /// The actual algoritem
        /// </summary>
        public void StartAlgoritem()
        {
            //a default check
            checkConditions();

            //Puts the containers in place
            PlaceContainers();

            //Calculate the current balance of the ship
            if (!ship.CalculateBalance())
            {
                while (!ship.CalculateBalance())
                {
                    BalanceShip();
                }
            }
        }

        /// <summary>
        /// A default check if the algoritem conditions are met.
        /// </summary>
        private void checkConditions()
        {
            int _totalValuable = 0;
            int _totalCooled = 0;

            //check for min ship weight
            if (DockedContainersWeight < ship.MinWeight)
                throw new ExceptionHandler(
                    "The total docked containers weight do not require the minimum ship weight of {0}! other wise the ship will capsize!",
                    ship.MinWeight);

            //check for max ship weight
            if (DockedContainersWeight > ship.MaxWeight)
                throw new ExceptionHandler(
                    "The total docked containers weight is higher than the maximum ship weight of {0} other wise it will capsize!",
                    ship.MaxWeight);

            //check totalValuable containers
            _totalValuable = DockedContainers.FindAll(c => c.Valuable).Count;

            if (_totalValuable > 4)
                throw new ExceptionHandler(
                    "There are to many valuable containers! There are current {0} and there are only 4 allowed on this ship",
                    _totalValuable);

            //Check totalCooled containers
            _totalCooled = DockedContainers.FindAll(c => c.Cooled).Count;

            if ((_totalValuable > 2 && _totalCooled > 10))
                throw new ExceptionHandler(
                    "There are to many cooled containers! There are current {0} and you can only have at max 10 if there are no valuable containers. the total valuable containers are {1}",
                    _totalCooled, _totalValuable);
        }

        /// <summary>
        /// Places the docked containers to the right selections.
        /// </summary>
        private void PlaceContainers()
        {
            //Loops through every selection of the ship and try to fit the containers
            for (int i = 0; i < 8; i++)
            {
                //Check if there are containers in the docking list and returns true or false 
                bool _containsValue = DockedContainers.Exists(c => c.Valuable);
                bool _containsCooled = DockedContainers.Exists(c => c.Cooled);
                bool _containsdefault = DockedContainers.Exists(c => c.Standard);

                //select the current selection by the for loop Index
                Selection selection = ship.Selections[i];

                //Check if there are valuable containers and if the selection places are met
                if (_containsValue && (selection.Place == 1 || selection.Place == 2 || selection.Place == 7 ||
                                       selection.Place == 8))
                {
                    //Find all the valuable containers
                    List<Container> _tempValueContainers = DockedContainers.FindAll(c => c.Valuable);

                    //Foreach through the valuable container list
                    foreach (Container container in _tempValueContainers.ToList())
                    {
                        //Send the container too the selection class and try's to add the container to the list of the selection.
                        bool result = selection.AddContainer(container);

                        //if result is true then the placed container can be deleted.
                        if (result)
                        {
                            _tempValueContainers.Remove(container);
                            DockedContainers.Remove(container);
                        }
                    }
                }

                //Check if there are cooled containers and if the selection places are met
                if (_containsCooled && (selection.Place == 1 || selection.Place == 2))
                {
                    //Find all the cooled containers
                    List<Container> _tempCooledContainers = DockedContainers.FindAll(c => c.Cooled);

                    //Foreach through the cooled container list
                    foreach (Container container in _tempCooledContainers.ToList())
                    {
                        //Send the container too the selection class and try's to add the container to the list of the selection.
                        bool result = selection.AddContainer(container);

                        //if result is true then the placed container can be deleted.
                        if (result)
                        {
                            _tempCooledContainers.Remove(container);
                            DockedContainers.Remove(container);
                        }
                    }
                }

                //Check if there are default containers
                if (_containsdefault)
                {
                    //Find all the default containers
                    List<Container> _tempDefaultContainers = DockedContainers.FindAll(c => c.Standard);

                    //Foreach through the default container list
                    foreach (Container container in _tempDefaultContainers.ToList())
                    {
                        //Send the container too the selection class and try's to add the container to the list of the selection.
                        bool result = selection.AddContainer(container);

                        //if result is true then the placed container can be deleted.
                        if (result)
                        {
                            _tempDefaultContainers.Remove(container);
                            DockedContainers.Remove(container);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Balance the ship if needed
        /// </summary>
        private void BalanceShip()
        {
            Enum Side;
            //Gets the weight of the left and right side
            decimal _leftWeight = ship.GetTotalSides().Item1; //left
            decimal _rightWeight = ship.GetTotalSides().Item2; //right

            //Decides which side is the most heaviest
            Side = _leftWeight > _rightWeight ? Selection.RowSide.left : Selection.RowSide.right;
            //Finds all the selections of each sides
            List<Selection> _HSelection = ship.Selections.FindAll(s => s.Side == (Selection.RowSide) Side);
            List<Selection> _LSelection = ship.Selections.FindAll(s => s.Side != (Selection.RowSide) Side);

            //foreach through all the selections on the lowest side
            foreach (Selection _currentSelection in _LSelection)
            {   
                //checks again if the balance is below 20%
                if (ship.CalculateBalance())
                    break;
                //foreach through all the selections of the heaviest side
                foreach (Selection _HSSelection in _HSelection)
                {
                    //checks again if the balance is below 20%
                    if (ship.CalculateBalance())
                        break;

                    foreach (Container container in _HSSelection.Containers.ToList())
                    {
                        //checks again if the balance is below 20%
                        if (ship.CalculateBalance())
                            break;
                        //if container is equal to valuable then skip
                        if (container.Valuable)
                            continue;
                        //if container is cooled and the current selection place is not 1 or 2 then skip
                        if (container.Cooled && !(_currentSelection.Place == 1 || _currentSelection.Place == 2))
                            continue;
                        //check if the container fits in its new selection
                        bool result = _currentSelection.AddContainer(container);
                        //if result is true then delete out _HSSelection
                        if (result)
                            _HSSelection.DeleteContainer(container);
                    }
                }
            }
        }
    }
}
