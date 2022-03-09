using Siemens.Engineering;
using Siemens.Engineering.HW;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiaProject
{
    public class Subnet
    {
        public string name;
        public SubnetType type;
        public Subnet() { name = ""; type = SubnetType.xxxUNDEFxxx; }
        public Subnet(string Subnetname, SubnetType subnet) { name = Subnetname; type = subnet; }
    }
    public class Device
    {
        public string name;
        public DeviceClassification deviceType;
        public Device() { name = ""; deviceType = DeviceClassification.xxxUNDEFxxx; }
        public Device(string deviceName, DeviceClassification deviceType) { name = deviceName; this.deviceType = deviceType; }
    }
    public class TiaPortalProject
    {
        public string name;
        public List<Subnet> subnets;
        public List<Device> devices;
        public TiaPortalProject(string projectName) { name = projectName; subnets = new List<Subnet>(); devices = new List<Device>(); }

        //Methods
        public string ListSubnets()
        {
            string myReturnString = "";
            foreach (Subnet item in subnets)
            {
                myReturnString += "Subnet " + item.name + " is of type " + item.type.ToString() + "\r\n";
            }
            return myReturnString;
        }
        public string ListDevices()
        {
            string myReturnString = "";
            foreach (Device item in devices)
            {
                myReturnString += "Device " + item.name + " is of type " + item.deviceType.ToString() + "\r\n";
            }
            return myReturnString;
        }
        public string ListDevices(DeviceClassification ClassificationToShow)
        {
            string myReturnString = "";
            foreach (Device item in devices)
            {
                if (item.deviceType == ClassificationToShow)
                {
                    myReturnString += "Device " + item.name + "\r\n";
                }
            }
            return myReturnString;
        }
        public bool CreateProjectInTia()
        {
            bool success = true;
            TiaPortal MyTiaPortal = new TiaPortal(TiaPortalMode.WithUserInterface);
            ProjectComposition projectComposition = MyTiaPortal.Projects;
            DirectoryInfo targetDirectory = new DirectoryInfo(@"D:\Kurse");
            Project project = projectComposition.Create(targetDirectory, name);
            
            foreach (Device item in devices)
            {
                string OrderNo;
                string Version;
                switch (item.deviceType)
                {
                    case DeviceClassification.S7_300:
                        OrderNo = "6ES7 317-2EK14-0AB0";
                        Version = "V3.2";
                        break;
                    case DeviceClassification.S7_400:
                        OrderNo = "6ES7 416-3ES07-0AB0";
                        Version = "V7.0";
                        break;
                    case DeviceClassification.ET200SP:
                        OrderNo = "6ES7 512-1DK01-0AB0";
                        Version = "V2.6";
                        break;
                    case DeviceClassification.S7_1500:
                        OrderNo = "6ES7 516-3AN01-0AB0";
                        Version = "V2.6";
                        break;
                    case DeviceClassification.xxxUNDEFxxx:
                        success = false;
                        continue;
                    default:
                        success = false;
                        continue;
                }
                string MLFB = "OrderNumber:" + OrderNo + "/" + Version;
                project.Devices.CreateWithItem(MLFB, item.name, item.name);
            }
            foreach (Subnet item in subnets)
            {
                SubnetComposition subnets = project.Subnets;
                string subnettype;
                switch (item.type)
                {
                    case SubnetType.PROFINET:
                        subnettype = "System:Subnet.Ethernet";
                        break;
                    case SubnetType.PROFIBUS:
                        subnettype = "System:Subnet.Profibus";
                        break;
                    case SubnetType.ASI:
                        subnettype = "System:Subnet.Asi";
                        break;
                    case SubnetType.MPI:
                        subnettype = "System:Subnet.Mpi";
                        break;
                    case SubnetType.xxxUNDEFxxx:
                        success = false;
                        continue;
                    default:
                        success = false;
                        continue;
                }
                Siemens.Engineering.HW.Subnet newSubnet = subnets.Create(subnettype, item.name);

            }

            return success;
        }
    }
    public enum DeviceClassification { S7_300, S7_400, ET200SP, S7_1500, xxxUNDEFxxx };
    public enum SubnetType { PROFINET, PROFIBUS, ASI, MPI, xxxUNDEFxxx };
}
