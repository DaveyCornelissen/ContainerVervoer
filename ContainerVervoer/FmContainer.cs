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

        private List<Container> visualContainerList = new List<Container>();

        public FmContainer()
        {
            InitializeComponent();
        }

        private void btnSetShip_Click(object sender, EventArgs e)
        {
            int shipWeight = tbShipMaxWeight.Text == "" ? 0 : Convert.ToInt32(tbShipMaxWeight.Text);

            if (shipWeight > 12000000)
            {
                rtbProgramLog.Text = String.Format("Ship frame cant handel more than {0} kg! maximum weight of this schip is 12000.000 kg.", shipWeight);
            }
            else
            {
                logicServices = new Logic(shipWeight);
            }
        }

        private void btnAddContainer_Click(object sender, EventArgs e)
        {

            int ContainerWeight = tbSetContainerWeight.Text == "" ? 0 : Convert.ToInt32(tbSetContainerWeight.Text);



            if (!(ContainerWeight <= 4000 || ContainerWeight >= 30000))
            {
                Container newContainer = new Container
                {
                    Weight = ContainerWeight,
                    Standard = rbStandard.Checked,
                    Valuable = rbValuable.Checked,
                    Cooled = rbCooled.Checked
                };

                //add containers to logicServices list
                logicServices.TotalContainers.Add(newContainer);

                //add to visual listbox
                visualContainerList.Add(newContainer);

                //update listbox total containers
                lbContainerUpdate();
            }
            else
            {
                rtbProgramLog.Text = "Container weight is out of range it needs to be beteen 4000 & 30000 kg!";
            }

            
        }

        private void btnRemoveContainer_Click(object sender, EventArgs e)
        {
            var removeIndex = lbContainerList.SelectedIndex;

            if (removeIndex != -1)
            {
                logicServices.TotalContainers.RemoveAt(removeIndex);
                visualContainerList.RemoveAt(removeIndex);

                lbContainerUpdate();
            }
            else
            {
                MessageBox.Show("Please select a container first!");
            }
        }

        /// <summary>
        /// Update the current container list.
        /// </summary>
        private void lbContainerUpdate()
        {
            lbContainerList.Items.Clear();
            foreach (Container container in visualContainerList)
            {
                lbContainerList.Items.Add(container.ToString());
            }
        }

        private void lbUpdateShipInfo()
        {

        }

    }
}
