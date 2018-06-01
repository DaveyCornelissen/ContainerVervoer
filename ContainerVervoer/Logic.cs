using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    public class Logic
    {
        private Ship ship;

        public List<Container> TotalContainers { get; set; } = new List<Container>();

        public Logic(int maxWeight)
        {
           ship = new Ship(maxWeight);
        }

        public void AddContainer(int weight, bool standard, bool valuable, bool Cooled)
        {
            Container newContainer = new Container
            {
                Weight = weight,
                Standard = standard,
                Valuable = valuable,
                Cooled = Cooled
            };

            TotalContainers.Add(newContainer);
        }
    }
}
