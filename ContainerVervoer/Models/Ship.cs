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
            for (int i = 0; i < total; i++)
            {
                Selection selection = new Selection
                {
                    Id = i
                };

                Selections.Add(selection);
            }
        }
    
    }
}
