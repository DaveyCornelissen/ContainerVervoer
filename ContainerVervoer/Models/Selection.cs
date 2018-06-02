using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainerTransport;

namespace ContainerVervoer.Models
{
    public class Selection
    {

        public int Id { get; set; }

        public bool ContainsValue { get; set; }

        public decimal SelectionWeight { get; set; }

        public List<Container> Containers { get; set; } = new List<Container>();
    }
}
