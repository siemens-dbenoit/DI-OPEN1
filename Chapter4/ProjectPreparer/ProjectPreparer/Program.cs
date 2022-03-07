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

            // ohne Console.ReadLine() Abfrage beendet die Applikation automatisch 
            // without Console.ReadLine() application will terminate automatically
            Console.ReadLine();
            
        }
    }
}
