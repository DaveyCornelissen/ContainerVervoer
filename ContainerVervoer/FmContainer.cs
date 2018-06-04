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

        /// <summary>
        /// Set the ship weight and also creates the logic for the ship. and enables the start and add container buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetShip_Click(object sender, EventArgs e)
        {
            logicServices = new Logic(nbShipWeight.Value);

            btnAddContainer.Enabled = true;
            btnStart.Enabled = true;

            //show ship is created
            rtbProgramLog.Clear();

            rtbProgramLog.Text = String.Format("You successfully created the ship with the weight of {0} kg!",
                nbShipWeight.Value);

            lbUpdateShipInfo();
        }

        /// <summary>
        /// Adds the container to the docked container list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            try
            {
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
            catch
            {
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
            lblTotalContainers.Text = lbContainerList.Items.Count.ToString();

            //TotalWeight of containers
            lblTotalContainerWeight.Text = logicServices.DockedContainersWeight.ToString();

            //Max weight of containers
            lblShipMaxWeight.Text = logicServices.ship.MaxWeight.ToString();

            //min weight of containers
            lblShipMinWeight.Text = (logicServices.ship.MaxWeight / 2).ToString();

            //The balance of the ship
            lblShipBalance.Text = logicServices.ship.Balance.ToString();
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
               //Starts the algoritem
               logicServices.StartAlgoritem();
               //adds the result to the view
               SetSelectionList(logicServices.ship);
               
               //Update ship info after placement
               lbUpdateShipInfo();
            }
            catch (ExceptionHandler exception)
            {
                rtbProgramLog.Clear();
                rtbProgramLog.Text = exception.Message;
            }
        }

        /// <summary>
        /// Adds the result of the algoritem to the lists where the containers belong.
        /// </summary>
        /// <param name="ship"></param>
        private void SetSelectionList(Ship ship)
        {
            //Clear all selection lists before filling them
            lbContainerSection1.Items.Clear();
            lbContainerSection2.Items.Clear();
            lbContainerSection3.Items.Clear();
            lbContainerSection4.Items.Clear();
            lbContainerSection5.Items.Clear();
            lbContainerSection6.Items.Clear();
            lbContainerSection7.Items.Clear();
            lbContainerSection8.Items.Clear();

            foreach (var selection in ship.Selections)
            {
                foreach (Container container in selection.Containers)
                {
                    switch (selection.Place)
                    {
                        case 1:
                            lbContainerSection1.Items.Add(container.ToString());
                            break;
                        case 2:
                            lbContainerSection2.Items.Add(container.ToString());
                            break;
                        case 3:
                            lbContainerSection3.Items.Add(container.ToString());
                            break;
                        case 4:
                            lbContainerSection4.Items.Add(container.ToString());
                            break;
                        case 5:
                            lbContainerSection5.Items.Add(container.ToString());
                            break;
                        case 6:
                            lbContainerSection6.Items.Add(container.ToString());
                            break;
                        case 7:
                            lbContainerSection7.Items.Add(container.ToString());
                            break;
                        case 8:
                            lbContainerSection8.Items.Add(container.ToString());
                            break;
                    }
                    
                }
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
