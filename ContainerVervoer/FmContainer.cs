using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerTransport
{
    public partial class FmContainer : Form
    {
        private Logic logicServices;

        private List<Container> TotalcontainerList;

        public FmContainer()
        {
            InitializeComponent();
        }

        private void btnSetShip_Click(object sender, EventArgs e)
        {
            logicServices = new Logic(Convert.ToInt32(tbShipMaxWeight.Text));
        }

        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            var checkStandard = rbStandard.Checked;
            var checkValuable = rbValuable.Checked;
            var checkCooled = rbCooled.Checked;

            logicServices.AddContainer(Convert.ToInt32(tbSetContainerWeight.Text), checkStandard, checkValuable, checkCooled);

            updateContainerLb();
        }

        private void updateContainerLb()
        {
            lbContainerList.Items.Clear();
            foreach (Container container in logicServices.TotalContainers)
            {
                lbContainerList.Items.Add(container.ToString());
            }
        }
    }
}
