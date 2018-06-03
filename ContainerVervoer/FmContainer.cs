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

        public FmContainer()
        {
            InitializeComponent();

            //prevent not allowed actions
            btnAddContainer.Enabled = false;
            btnStart.Enabled = false;
        }

        private void btnSetShip_Click(object sender, EventArgs e)
        {
            logicServices = new Logic(nbShipWeight.Value);

            btnAddContainer.Enabled = true;
            btnStart.Enabled = true;

            //show ship is created
            rtbProgramLog.Clear();

            rtbProgramLog.Text = String.Format("You succesfully created the ship with the weight of {0} kg!",
                nbShipWeight.Value);

            lbUpdateShipInfo();
        }

        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            //add containers to logicServices list
            logicServices.AddContainer(nbContainerWeight.Value, rbStandard.Checked, rbValuable.Checked, rbCooled.Checked);

            //update listbox total containers
            lbContainerUpdate();
        }

        /// <summary>
        /// Remove the container from the container list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveContainer_Click(object sender, EventArgs e)
        {
            var removeIndex = lbContainerList.SelectedIndex;

            if (removeIndex != -1)
            {
                logicServices.RemoveContainer(removeIndex);

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
            foreach (Container container in logicServices.DockedContainers)
            {
                lbContainerList.Items.Add(container.ToString());
            }

            lbUpdateShipInfo();
        }

        /// <summary>
        /// Update ship and container info to the form
        /// </summary>
        private void lbUpdateShipInfo()
        {
            //Total containers
            lblTotalContainers.Text = logicServices.DockedContainers.Count().ToString();

            //TotalWeight of containers
            lblTotalContainerWeight.Text = logicServices.DockedContainersWeight.ToString();

            //Max weight of containers
            lblShipMaxWeight.Text = logicServices.ship.MaxWeight.ToString();

            //min weight of containers
            lblShipMinWeight.Text = (logicServices.ship.MaxWeight / 2).ToString();
        }

        /// <summary>
        /// start the algoritem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                logicServices.StartAlgoritem();
            }
            catch (ExceptionHandler exception)
            {
                rtbProgramLog.Clear();

                rtbProgramLog.Text = exception.Message;
            }
        }

        /// <summary>
        /// Reset the application and its content
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
