using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    public class Ship
    {
        public int MaxWeight { get; private set; }

        public int Balance { get; set; }

        public List<Container> Section1 { get; set; }

        public List<Container> Section2 { get; set; }

        public List<Container> Section3 { get; set; }

        public List<Container> Section4 { get; set; }

        public List<Container> Section5 { get; set; }

        public List<Container> Section6 { get; set; }

        public List<Container> Section7 { get; set; }

        public List<Container> Section8 { get; set; }

        public Ship(int maxWeight)
        {
            MaxWeight = maxWeight;
        }
    }
}
