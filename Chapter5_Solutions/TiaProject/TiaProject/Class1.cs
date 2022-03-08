using System;
using System.Collections.Generic;
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
        public Subnet(string Subnetname, SubnetType subnet) { name = Subnetname; type = subnet;  }
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
                myReturnString+= "Device "+ item.name + " is of type "+item.deviceType.ToString()+"\r\n";
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
            return false;
        }
    }
    public enum DeviceClassification { S7_300, S7_400, ET200SP, S7_1500, xxxUNDEFxxx };
    public enum SubnetType { PROFINET, PROFIBUS, ASI, MPI, xxxUNDEFxxx };
}
