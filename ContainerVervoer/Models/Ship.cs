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

        //create selections to the amount given by creating a ship
        private void CreateSelections(int total)
        {
            for (int i = 1; i <= total; i++)
            {
                Selection selection = new Selection
                {
                    Place = i
                };

                Selections.Add(selection);
            }
        }

        public decimal CalculateBalance()
        {
            decimal selectionRowTop = 0;
            decimal selectionRowBottom = 0;

            for (int i = 0; i < 8; i++)
            {
                if (i == 0 || i == 2 || i == 4 || i == 6)
                {
                    selectionRowTop += Selections[i].SelectionWeight;
                }
                else
                {
                    selectionRowBottom += Selections[i].SelectionWeight;
                }
            }

            return Balance = (selectionRowBottom - selectionRowTop) / selectionRowTop * 100;
        }
    
    }
}
