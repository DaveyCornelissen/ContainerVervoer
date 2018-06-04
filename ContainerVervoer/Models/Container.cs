using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    public class Container
    {
        public decimal MaxWeight { get; private set; }

        public decimal MinWeight { get; private set; }

        public decimal Weight { get; set; }

        public bool Standard { get; set; }

        public bool Valuable { get; set; }

        public bool Cooled { get; set; }

        public Container()
        {
            MaxWeight = 30000;
            MinWeight = 4000;
        }

        /// <summary>
        /// Contvert this class to string so it can be viewed by a listbox
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Container weight: " + Weight + " Standard: " + Standard + " Valuable: " + Valuable + " Cooled: " +
                   Cooled;
        }
    }
}
