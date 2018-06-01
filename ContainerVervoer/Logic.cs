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
        private Ship ship;

        public ObservableCollection<Container> TotalContainers { get; set; } = new ObservableCollection<Container>();

        public Logic(int maxWeight)
        {
           ship = new Ship(maxWeight);
        }

        public void AddContainer(int weight, bool standard, bool valuable, bool Cooled)
        {
            
        }

        public void RemoveContainer(object index)
        {
            if (index is Container)
            {
                TotalContainers.Remove((Container)index);
            }
            
        }
    }
}
