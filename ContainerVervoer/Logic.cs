using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void RemoveContainer(int index)
        {
            DockedContainersWeight -= DockedContainers[index].Weight;

            DockedContainers.RemoveAt(index);
        }


        public void checkConditions()
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
                    ship.MinWeight);

            //check totalValuable containers
            _totalValuable = DockedContainers.FindAll(c => c.Valuable).Count;

            if (_totalValuable > 4)
                throw new ExceptionHandler("There are to many valuable containers! There are current {0} and there are only 4 allowed on this ship", _totalValuable);

            //Check totalCooled containers
            _totalCooled = DockedContainers.FindAll(c => c.Cooled).Count;

            if (_totalCooled)
                throw new ExceptionHandler("");
        }
    }
}
