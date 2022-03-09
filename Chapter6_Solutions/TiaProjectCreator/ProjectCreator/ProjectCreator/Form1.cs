using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static TiaProject.TiaPortalProject myProject;

        private void btnInitializeProject_Click(object sender, EventArgs e)
        {
            // Create new instance of TIA Portal
            myProject = new TiaProject.TiaPortalProject(tbProjectName.Text);

            //Enable Device creation
            tbDeviceName.Enabled = true;
            cbDeviceType.Enabled = true;
            btnAddDevice.Enabled = true;

            //Enable Subnet creation
            tbSubnetName.Enabled = true;
            cbSubnetType.Enabled = true;
            btnAddSubnet.Enabled = true;

            //Enable Project creation
            btnCreateProject.Enabled = true;

            //Disable Project Initialization
            tbProjectName.Enabled = false;
            btnInitializeProject.Enabled = false;
        }

        private void btnAddSubnet_Click(object sender, EventArgs e)
        {
            //Check if subnet has already been there before
            bool found = false;
            foreach (TiaProject.Subnet item in myProject.subnets)
            {
                if (item.name == tbSubnetName.Text)
                {
                    found = true;
                }
            }
            if (found)
            {
                //if Subnet has been found, show message and do not add subnet
                MessageBox.Show("A subnet with the same name has been found, please rename!");
            }
            else
            {
                //Subnet was not found --> Select the correct subnet type
                TiaProject.SubnetType myClassification;
                if ((string)cbSubnetType.SelectedItem == "PROFINET")
                {
                    myClassification = TiaProject.SubnetType.PROFINET;
                }
                else if ((string)cbSubnetType.SelectedItem == "PROFIBUS")
                {
                    myClassification = TiaProject.SubnetType.PROFIBUS;
                }
                else if ((string)cbSubnetType.SelectedItem == "ASI")
                {
                    myClassification = TiaProject.SubnetType.ASI;
                }
                else if ((string)cbSubnetType.SelectedItem == "MPI")
                {
                    myClassification = TiaProject.SubnetType.MPI;
                }
                else
                {
                    myClassification = TiaProject.SubnetType.xxxUNDEFxxx;
                }
                // Add subnet to collection
                myProject.subnets.Add(new TiaProject.Subnet(tbSubnetName.Text, myClassification));
                //Update the list box
                lbSubnets.Items.Clear();
                foreach (TiaProject.Subnet item in myProject.subnets)
                {
                    lbSubnets.Items.Add(item.name + " is " + item.type.ToString());
                }
            }
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            //Check if Device was already there
            bool found = false;
            foreach (TiaProject.Device item in myProject.devices)
            {
                if (item.name == tbDeviceName.Text)
                {
                    found = true;
                }
            }
            if (found)
            {
                //Device was already found --> show message and do not add
                MessageBox.Show("A device with the same name has been found, please rename!");
            }
            else
            {
                //Select correct device type in enumeration
                TiaProject.DeviceClassification myClassification;
                if ((string)cbDeviceType.SelectedItem == "ET200SP")
                {
                    myClassification = TiaProject.DeviceClassification.ET200SP;

                }
                else if ((string)cbDeviceType.SelectedItem == "S7-1500")
                {
                    myClassification = TiaProject.DeviceClassification.S7_1500;
                }
                else if ((string)cbDeviceType.SelectedItem == "S7-300")
                {
                    myClassification = TiaProject.DeviceClassification.S7_300;
                }
                else if ((string)cbDeviceType.SelectedItem == "S7-400")
                {
                    myClassification = TiaProject.DeviceClassification.S7_400;

                }
                else
                {
                    myClassification = TiaProject.DeviceClassification.xxxUNDEFxxx;
                }
                //add device
                myProject.devices.Add(new TiaProject.Device(tbDeviceName.Text, myClassification));
                //Update List box
                lbDevices.Items.Clear();
                foreach (TiaProject.Device item in myProject.devices)
                {
                    lbDevices.Items.Add(item.name + " is " + item.deviceType.ToString());
                }
            }
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            //Create the project
            if (myProject.CreateProjectInTia())
            {
                //success true
                MessageBox.Show("Project creation was successfull!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //success false
                MessageBox.Show("Project creation was not successfull!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
