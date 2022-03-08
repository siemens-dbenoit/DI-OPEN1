using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiaProject;

namespace TiaProjectTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konstruktor von TiaPortalProject
            //Constructor for TiaPortalProject
            TiaPortalProject MyProject = new TiaPortalProject("MyFirstProject");

            //Standardkonstruktor von Subnet
            //Standard constructor of Subnet
            MyProject.subnets.Add(new Subnet());
            MyProject.subnets[0].name = "SUBNET_1";
            MyProject.subnets[0].type = SubnetType.PROFINET;

            //weiterer Konstruktor von Subnet
            //further constructor of Subnet
            MyProject.subnets.Add(new Subnet("MYSECONDSUBNET", SubnetType.PROFIBUS));

            //Standardkonstruktor von Devices
            //Standard constructor of Devices
            MyProject.devices.Add(new Device());
            MyProject.devices[0].name = "PLC_1";
            MyProject.devices[0].deviceType = DeviceClassification.S7_1500;

            //weiterer Konstruktor von Devices
            //further constructor of Devices
            MyProject.devices.Add(new Device("PLC_2", DeviceClassification.ET200SP));

            //Methoden auf Element der Klasse
            //Methodes of elements of the class
            Console.Write("xxxSUBNETSxxx\r\n");
            Console.Write(MyProject.ListSubnets());
            Console.Write("xxxDEVICESxxx\r\n");
            Console.Write(MyProject.ListDevices());
            Console.Write("xxxSPEC_DEVICESxxx\r\n");
            Console.Write(MyProject.ListDevices(DeviceClassification.S7_1500));
            Console.ReadLine();
        }
    }
}
