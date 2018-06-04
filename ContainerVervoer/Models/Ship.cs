using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainerVervoer.Models;

namespace ContainerTransport
{
    public class Ship
    {
        public decimal MaxWeight { get; private set; }

        public decimal MinWeight { get; private set; }

        public decimal Balance { get; set; }

        public List<Selection> Selections { get; set; } = new List<Selection>();


        public Ship(decimal maxWeight, int totalSelections)
        {
            MaxWeight = maxWeight;
            MinWeight = MaxWeight / 2;

            CreateSelections(totalSelections);
        }

        /// <summary>
        /// create selections to the amount given by creating a ship
        /// </summary>
        /// <param name="total"></param>
        private void CreateSelections(int total)
        {
            for (int i = 1; i <= total; i++)
            {
                Selection selection = new Selection
                {
                    Place = i
                };

                if (i == 1 || i == 3 || i == 5 || i == 7)
                {
                    selection.Side = Selection.RowSide.right;
                }
                else
                {
                    selection.Side = Selection.RowSide.left;
                }

                Selections.Add(selection);
            }
        }

        /// <summary>
        /// Gets the total weight of the two sides
        /// </summary>
        /// <returns>Totalweightleft, TotalweightRight</returns>
        public (decimal, decimal) GetTotalSides()
        {
            decimal[] _selectionWeight = new decimal[2];

            foreach (Selection selection in Selections)
            {
                if (selection.Side == Selection.RowSide.left)
                {
                    _selectionWeight[0] += selection.SelectionWeight;
                }
                else
                {
                    _selectionWeight[1] += selection.SelectionWeight;
                }
            }

            decimal TotalLeft = _selectionWeight[0];
            decimal TotalRight = _selectionWeight[1];

            return (TotalLeft, TotalRight);
        }

        /// <summary>
        /// Calculate the balance of the ship.
        /// </summary>
        /// <returns></returns>
        public bool CalculateBalance()
        {
            decimal[] _side = new decimal[2];
            _side[0] = GetTotalSides().Item1; //left
            _side[1] = GetTotalSides().Item2; //right

            decimal HeightsNumber = _side.Max();
            decimal LowestNumber = _side.Min();

            //Calculate the current balance
            decimal _balance = (LowestNumber - HeightsNumber) / HeightsNumber * 100;

            if (_balance >= -20)
            {
                Balance = _balance;
                return true;
            }
            return false;
        }
    
    }
}
