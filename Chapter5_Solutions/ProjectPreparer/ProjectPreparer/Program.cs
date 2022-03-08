using OpennessEncapsulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPreparer
{
    class Program
    {
        static void Main(string[] args)
        {
            OpennessFunctions opnsFct = new OpennessFunctions();
            opnsFct.InitConfig(@"D:\Kurse",
                "GeneratedTiaProject",
                @"D:\00_DIOPEN\DI_OPEN1_Solutions\Chapter5\Bib\TIA-OPEN1_Lib_V16\TIA-OPEN1_Lib_V16.al16");

            OpennessFunctions.SetWhitelist(System.Diagnostics.Process.GetCurrentProcess().ProcessName, System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            // Result gibt die Eingaben des Benutzers wieder
            // Result reproduces user input
            int result = 0;
            Console.Title = "ProjectPreparer";

            // Konsolenausgaben zur Wahl der CPU-Familie
            // Console output for CPU category selection
            Console.WriteLine("Bitte wählen Sie:");
            Console.WriteLine("1: klassische CPU (S7-300)");
            Console.WriteLine("2: neue CPU (S7-1500)");
            Console.WriteLine("Ihre Eingabe: ");
            Console.WriteLine("Please select:");
            Console.WriteLine("1: classic CPU (S7-300)");
            Console.WriteLine("2: new CPU (S7-1500)");
            Console.WriteLine("Your input: ");
            // Einlesen der Benutzereingabe
            // Read user input       
            string classicNew = Console.ReadLine();

            //---------------------------------------------------
            // Todo
            // Handling der Eingabe des Benutzers
            // Result um 1 inkrementieren, wenn classicNew == "1"
            // Result um 2 inkrementieren, wenn classicNew == "2"
            //---------------------------------------------------
            // Todo
            // Handling of user input
            // Increment result by 1 if classicNew == "1"
            // Increment result by 2 if classicNew == "2"
            //---------------------------------------------------
            if (classicNew == "1")
            {
                result += 1;
            }
            else if (classicNew == "2")
            {
                result += 2;
            }
            // Konsolenausgaben für die Auswahl der dezentralen Peripherie
            // Console output for decentral periphery selection
            Console.WriteLine("Bitte wählen Sie:");
            Console.WriteLine("1: ohne dezentrale Peripherie-Station");
            Console.WriteLine("2: mit dezentraler Peripherie-Station");
            Console.WriteLine("Ihre Eingabe: ");
            Console.WriteLine("Please select:");
            Console.WriteLine("1: without decentral periphery station");
            Console.WriteLine("2: with decentral periphery station");
            Console.WriteLine("Your input: ");
            // Einlesen der Benutzereingabe
            // Read user input
            string decentral = Console.ReadLine();

            //---------------------------------------------------
            // Todo
            // Handling der Eingabe des Benutzers
            // Result um 10 inkrementieren, wenn Decentral == "1"
            // Result um 20 inkrementieren, wenn Decentral == "2"
            //---------------------------------------------------
            // Todo
            // Handling of user input
            // Increment result by 10 if decentral == "1"
            // Increment result by 20 if decentral == "2"
            //---------------------------------------------------
            if (decentral == "1")
            {
                result += 10;
            }
            else if (decentral == "2")
            {
                result += 20;
            }

            // Konsolenausgabe für Main-Baustein
            // Console output for main block selection
            Console.WriteLine("Soll ein Main-Baustein eingefügt werden?");
            Console.WriteLine("j/n");
            Console.WriteLine("Ihre Eingabe: ");
            Console.WriteLine("Do you want to input a main block");
            Console.WriteLine("y/n");
            Console.WriteLine("Your input: ");
            // Einlesen der Benutzereingabe
            // Read user input
            string mainBlockInsert = Console.ReadLine();

            //---------------------------------------------------
            // Todo
            // Handling der Eingabe des Benutzers
            // Result um 100 inkrementieren, wenn mainBlockInsert == "j" oder "J"
            // Result um 200 inkrementieren, wenn mainBlockInsert == "n" oder "N"
            //---------------------------------------------------
            // Todo
            // Handling of user input
            // Increment result by 100 if mainBlockInsert == "y" oder "Y"
            // Increment result by 200 if mainBlockInsert == "n" oder "N"
            //---------------------------------------------------
            if (mainBlockInsert == "j" || mainBlockInsert == "J" || mainBlockInsert == "y" || mainBlockInsert == "Y")
            {
                result += 100;
            }
            else if (mainBlockInsert == "n" || mainBlockInsert == "N")
            {
                result += 200;
            }

            //---------------------------------------------------
            // Todo
            // Ausgabe der gewählten Parameter
            // Switch-Funktion verwenden, um alle Varianten abzudecken
            // Folgenden Text verwenden und abändern:
            // "Sie haben folgende Parameter gewählt:\r\n Klassische CPU, ohne dezentrale Peripherie, mit Mainblock"
            //---------------------------------------------------
            // Todo
            // Output of chosen parameters
            // Use switch statement to cover all variables
            // Use text as follows and correct if neccessary
            // "You've picked parameters as follows: \r\n classic CPU, without decentral periphery station, with main block"
            //---------------------------------------------------
            bool success;
            switch (result)
            {
                case 111:
                    // MainBlock = 100, ohne dezentrale Peripherie = 10, Classic = 1
                    // MainBlock = 100, without decentral periphery = 10, classic = 1
                    Console.WriteLine("Sie haben folgende Parameter gewählt:\r\nKlassische CPU, ohne dezentrale Peripherie, mit Mainblock");
                    Console.WriteLine("You've picked parameters as follows: \r\nClassic CPU, without decentral periphery, with main block");
                    Console.Write("Erzeuge das Projekt...");
                    Console.Write(" // Creating project...");
                    success = opnsFct.CreateProject(OpennessFunctions.CPUSelection.Classic_WithMain_WithoutDecentral);
                    Console.Write("fertig! // done! \r\n");                    
                    break;
                case 112:
                    // MainBlock = 100, ohne dezentrale Peripherie = 10, Plus = 2
                    // MainBlock = 100, without decentral periphery = 10, plus = 2
                    Console.WriteLine("Sie haben folgende Parameter gewählt:\r\nNeue CPU, ohne dezentrale Peripherie, mit Mainblock");
                    Console.WriteLine("You've picked parameters as follows: \r\nNew CPU, without decentral periphery, with main block");
                    Console.Write("Erzeuge das Projekt...");
                    Console.Write(" // Creating project...");
                    success = opnsFct.CreateProject(OpennessFunctions.CPUSelection.Innovation_WithMain_WithoutDecentral);
                    Console.Write("fertig! // done! \r\n");
                    break;
                case 121:
                    // MainBlock = 100, mit dezentraler Peripherie = 20, Classic = 1
                    // MainBlock = 100, with decentral periphery = 20, classic = 1
                    Console.WriteLine("Sie haben folgende Parameter gewählt:\r\nKlassische CPU, mit dezentraler Peripherie, mit Mainblock");
                    Console.WriteLine("You've picked parameters as follows: \r\nClassic CPU, with decentral periphery, with main block");
                    Console.Write("Erzeuge das Projekt...");
                    Console.Write(" // Creating project...");
                    success = opnsFct.CreateProject(OpennessFunctions.CPUSelection.Classic_WithMain_WithDecentral);
                    Console.Write("fertig! // done! \r\n");
                    break;
                case 122:
                    // MainBlock = 100, mit dezentraler Peripherie = 20, Plus = 2
                    // MainBlock = 100, with decentral periphery = 20, plus = 2
                    Console.WriteLine("Sie haben folgende Parameter gewählt:\r\nNeue CPU, mit dezentraler Peripherie, mit Mainblock");
                    Console.WriteLine("You've picked parameters as follows: \r\nNew CPU, with decentral periphery, with main block");
                    Console.Write("Erzeuge das Projekt...");
                    Console.Write(" // Creating project...");
                    success = opnsFct.CreateProject(OpennessFunctions.CPUSelection.Innovation_WithMain_WithDecentral);
                    Console.Write("fertig! // done! \r\n");
                    break;
                case 222:
                    // kein Mainblock = 200, mit dezentraler Peripherie = 20, Plus = 2
                    // without main block = 200, with decentral periphery = 20, plus = 2
                    Console.WriteLine("Sie haben folgende Parameter gewählt:\r\nNeue CPU, mit dezentraler Peripherie, kein Mainblock");
                    Console.WriteLine("You've picked parameters as follows: \r\nNew CPU, with decentral periphery, without main block");
                    Console.Write("Erzeuge das Projekt...");
                    Console.Write(" // Creating project...");
                    success = opnsFct.CreateProject(OpennessFunctions.CPUSelection.Innovation_WithoutMain_WithDecentral);
                    Console.Write("fertig! // done! \r\n");
                    break;
                case 221:
                    // kein Mainblock = 200, mit dezentraler Peripherie = 20, Classic = 1
                    // without main block = 200, with decentral periphery = 20, classic = 1
                    Console.WriteLine("Sie haben folgende Parameter gewählt:\r\nKlassische CPU, mit dezentraler Peripherie, kein Mainblock");
                    Console.WriteLine("You've picked parameters as follows: \r\nClassic CPU, with decentral periphery, without main block");
                    Console.Write("Erzeuge das Projekt...");
                    Console.Write(" // Creating project...");
                    success = opnsFct.CreateProject(OpennessFunctions.CPUSelection.Classic_WithoutMain_WithDecentral);
                    Console.Write("fertig! // done! \r\n");
                    break;
                case 211:
                    // kein Mainblock = 200, ohne dezentrale Peripherie = 10, Classic = 1
                    // without main block = 200, without decentral periphery = 10, classic = 1
                    Console.WriteLine("Sie haben folgende Parameter gewählt:\r\nKlassische CPU, ohne dezentrale Peripherie, kein Mainblock");
                    Console.WriteLine("You've picked parameters as follows: \r\nClassic CPU, without decentral periphery, without main block");
                    Console.Write("Erzeuge das Projekt...");
                    Console.Write(" // Creating project...");
                    success = opnsFct.CreateProject(OpennessFunctions.CPUSelection.Classic_WithoutMain_WithoutDecentral);
                    Console.Write("fertig! // done! \r\n");
                    break;
                case 212:
                    // kein Mainblock = 200, ohne dezentrale Peripherie = 10, Plus = 2
                    // without main block = 200, without decentral periphery = 10, plus = 2
                    Console.WriteLine("Sie haben folgende Parameter gewählt:\r\nNeue CPU, ohne dezentrale Peripherie, ohne Mainblock");
                    Console.WriteLine("You've picked parameters as follows: \r\nNew CPU, without decentral periphery, without main block");
                    Console.Write("Erzeuge das Projekt...");
                    Console.Write(" // Creating project...");
                    success = opnsFct.CreateProject(OpennessFunctions.CPUSelection.Innovation_WithoutMain_WithoutDecentral);
                    Console.Write("fertig! // done! \r\n");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ihre Eingabe war nicht korrekt. Das Programm wird daher ohne Ergebnis beendet.");
                    Console.WriteLine("Your input was incorrect. The program will be closed without action.");
                    Console.ReadLine();
                    break;
            }


            success = opnsFct.CreateProject(ConfigurationToCreate: (OpennessFunctions.CPUSelection)result);

            // ohne Console.ReadLine() Abfrage beendet die Applikation automatisch 
            // without Console.ReadLine() application will terminate automatically
            Console.ReadLine();

            
        }
    }
}
