using Microsoft.Win32;
using Siemens.Engineering;
using Siemens.Engineering.HW;
using Siemens.Engineering.HW.Features;
using Siemens.Engineering.Library;
using Siemens.Engineering.SW;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OpennessEncapsulator
{
    public class OpennessFunctions
    {
        string _projectFolder = "";
        string _projectName = "";
        string _libraryPath = "";
        bool _isInitialized = false;


        /// <summary>
        /// constructor (empty)
        /// </summary>
        public OpennessFunctions()
        {
        }

        /// <summary>
        /// initializes the basic configuration of the class
        /// </summary>
        /// <param name="projectFolder"></param>
        /// <param name="projectName"></param>
        /// <param name="libraryPath"></param>
        public bool InitConfig(string projectFolder, string projectName, string libraryPath)
        {
            _projectFolder = projectFolder;
            _projectName = projectName;
            _libraryPath = libraryPath;

            // todo: check values

            _isInitialized = true;
            return true; // return check result
        }



        /// <summary>
        /// Creates one of the configurations that are allowed as Parameters
        /// </summary>
        /// <param name="ConfigurationToCreate">Member of Enum CPUSelection that defines which configuration is created</param>
        /// <returns>bool - This bool indicates whether a internal fault has happened or not (true = no internal error)</returns>
        public bool CreateProject(CPUSelection ConfigurationToCreate)
        {
            if (!_isInitialized)
            {
                // error!
            }

            try
            {
                #region Prepare Tia Project
                TiaPortal MyPortal = new TiaPortal(TiaPortalMode.WithUserInterface);

                //if (Directory.Exists(@"D:\Kurse\PreparedProject"))
                string projectPathComplete = _projectFolder + "\\" + _projectName;

                //if (Directory.Exists(@"D:\Kurse\PreparedProject"))
                if (Directory.Exists(projectPathComplete))
                {
                    //Directory.Delete(@"D:\Kurse\PreparedProject", true);
                    Directory.Delete(projectPathComplete, true);
                }
                //Project MyProject = MyPortal.Projects.Create(new System.IO.DirectoryInfo(@"D:\Kurse"), "PreparedProject");
                Project MyProject = MyPortal.Projects.Create(new System.IO.DirectoryInfo(_projectFolder), _projectName);

                //UserGlobalLibrary MyLib = MyPortal.GlobalLibraries.Open(new System.IO.FileInfo(@"D:\Kurse\Bib\TIA-OPEN1_Lib_V16\TIA-OPEN1_Lib_V16.al16"), OpenMode.ReadOnly);
                UserGlobalLibrary MyLib = MyPortal.GlobalLibraries.Open(new System.IO.FileInfo(_libraryPath), OpenMode.ReadOnly);
                
                #endregion

                #region Insert CPU 
                string CPUName = null;
                Device MyCPU = null;

                // Prüfung der letzten Stelle durch eine integer-Divison durch 10 --> Divisionsrest ist die Einer-Stelle der übergebenen Zahl
                // Check last digit of by integer division of 10 --> rest value is last digit of number
                if ((int)ConfigurationToCreate % 10 == 2)
                {
                    //Innovation - CPU
                    CPUName = "IO-Controller_Innovation";
                    MyCPU = MyProject.Devices.CreateFrom(MyLib.MasterCopyFolder.Folders.Find("Controllers").MasterCopies.Find(CPUName));
                }
                else
                {
                    //Classic-CPU
                    CPUName = "IO-Controller_Classic";
                    MyCPU = MyProject.Devices.CreateFrom(MyLib.MasterCopyFolder.Folders.Find("Controllers").MasterCopies.Find(CPUName));
                }
                #endregion

                #region Insert decentral periphery an connect
                // Sowohl bei Classic als auch Innovation ermitteln, ob Dezentrale Peripherie eingefügt werden muss
                // In any case of classic an innovation cpu check wether decentral periphery needs to be inserted
                if ((int)ConfigurationToCreate / 10 == 12 || (int)ConfigurationToCreate / 10 == 22)
                {
                    Device MyDecentralPeriphery = MyProject.Devices.CreateFrom(MyLib.MasterCopyFolder.Folders.Find("Decentral Periphery").MasterCopies.Find("IO device_1"));
                    DeviceItem MyPnSubmoduleDeviceItem = MyCPU.DeviceItems.First(DI => DI.Name.Contains("IO-Controller_")).DeviceItems.First(DI => DI.Name.Equals("PROFINET interface_1"));
                    NetworkInterface MyNetworkInterface = ((IEngineeringServiceProvider)MyPnSubmoduleDeviceItem).GetService<NetworkInterface>();
                    Subnet MySubnet = MyNetworkInterface.Nodes[0].CreateAndConnectToSubnet("PN-Subnet");
                    IoSystem MyIOSystem = MyNetworkInterface.IoControllers[0].CreateIoSystem("IO-System");
                    DeviceItem MyPnSubmoduleDeviceItemET200SP = MyDecentralPeriphery.DeviceItems.First(DI => DI.Name.Contains("IO device")).DeviceItems.First(DI => DI.Name.Contains("PROFINET"));
                    NetworkInterface MyET200SPNWI = ((IEngineeringServiceProvider)MyPnSubmoduleDeviceItemET200SP).GetService<NetworkInterface>();
                    MyET200SPNWI.Nodes[0].ConnectToSubnet(MySubnet);
                    MyET200SPNWI.IoConnectors[0].ConnectToIoSystem(MyIOSystem);
                }
                #endregion

                #region Insert main block
                if ((int)ConfigurationToCreate / 100 == 1)
                {
                    //MainBaustein einfügen
                    //Insert main block
                    DeviceItem MyCpuDeviceItem = MyCPU.DeviceItems.First(DI => DI.Name.Equals(CPUName));
                    string Blockname = "Main_Classic";
                    if (CPUName.Contains("Innovation"))
                    {
                        Blockname = "Main_Innova" +
                            "tion";
                    }
                    SoftwareContainer MySoftwareContainer = MyCpuDeviceItem.GetService<SoftwareContainer>();
                    PlcSoftware MyCpuSoftware = MySoftwareContainer.Software as PlcSoftware;
                    MyCpuSoftware.BlockGroup.Blocks.CreateFrom(MyLib.MasterCopyFolder.Folders.Find("Blocks").MasterCopies.Find(Blockname));
                }

                #endregion

                #region Postpare
                MyProject.ShowHwEditor(Siemens.Engineering.HW.View.Network);
                MyProject.Save();
                MyLib.Close();
                return true;
                #endregion
            }
            catch (Exception e)
            {
                return false;
            }
        }


        /// <summary>
        /// Creates a Registry Key that allows the Application to be run without the Openness Security Dialog.
        /// !!!
        /// Must be started with Administrator rights!
        /// !!!
        /// </summary>
        /// <param name="ApplicationName">The name of your application (without ".exe")</param>
        /// <param name="ApplicationStartupPath">The path where your application is located</param>
        public static void SetWhitelist(string ApplicationName, string ApplicationStartupPath)
        {

            RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            RegistryKey software = null;
            try
            {
                software = key.OpenSubKey(@"SOFTWARE\Siemens\Automation\Openness")
                    .OpenSubKey("16.0")
                    .OpenSubKey("Whitelist")
                    .OpenSubKey(ApplicationName + ".exe")
                    .OpenSubKey("Entry", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl);
            }
            catch (Exception)
            {

                //Eintrag in der Whitelist ist nicht vorhanden
                //Entry in whitelist is not available
                software = key.CreateSubKey(@"SOFTWARE\Siemens\Automation\Openness")
                    .CreateSubKey("16.0")
                    .CreateSubKey("Whitelist")
                    .CreateSubKey(ApplicationName + ".exe")
                    .CreateSubKey("Entry", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryOptions.None);
            }


            string lastWriteTimeUtcFormatted = String.Empty;
            DateTime lastWriteTimeUtc;
            HashAlgorithm hashAlgorithm = SHA256.Create();
            FileStream stream = File.OpenRead(ApplicationStartupPath);
            byte[] hash = hashAlgorithm.ComputeHash(stream);
            // this is how the hash should appear in the .reg file
            string convertedHash = Convert.ToBase64String(hash);
            software.SetValue("FileHash", convertedHash);
            lastWriteTimeUtc = new FileInfo(ApplicationStartupPath).LastWriteTimeUtc;
            // this is how the last write time should be formatted
            lastWriteTimeUtcFormatted = lastWriteTimeUtc.ToString(@"yyyy/MM/dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
            software.SetValue("DateModified", lastWriteTimeUtcFormatted);
            software.SetValue("Path", ApplicationStartupPath);
        }

        #region Enums
        /// <summary>
        /// Enumeration that is used for specifying the configuration to be created
        /// </summary>
        public enum CPUSelection
        {
            Classic_WithMain_WithoutDecentral = 111,
            Innovation_WithMain_WithoutDecentral = 112,
            Classic_WithMain_WithDecentral = 121,
            Innovation_WithMain_WithDecentral = 122,
            Innovation_WithoutMain_WithDecentral = 222,
            Classic_WithoutMain_WithDecentral = 221,
            Classic_WithoutMain_WithoutDecentral = 211,
            Innovation_WithoutMain_WithoutDecentral = 212
        };
        #endregion
    }
}
