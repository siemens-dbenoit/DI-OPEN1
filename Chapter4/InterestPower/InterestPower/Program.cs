using System;


namespace InterestPower
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------------------------------
            // Todo
            // Vollständiges Programm mit einer Do-While-Schleife umschließen, um Wiederholung zu ermöglichen
            // Abfrage am Ende des Programs, ob der Benutzer eine weitere Berechnung durchführen will
            // Wenn weitere Berechnung gewünscht, Programm wiederholen, sonst beenden
            //---------------------------------------------------------------------------------------------
            // Todo
            // Surround entire program with do-while-loop to allow multiple executions
            // Ask user to execute program again at the end
            // Repeat program if asked for, otherwise exit program
            //---------------------------------------------------------------------------------------------

            // Initialisierung der Konsole (um bei Wiederholung Ursprungszustand zur Verfügung zu haben)
            // Clear console (in case program is executed again)
            Console.Clear();
            Console.ResetColor();
            Console.Title = "InterestPower";
            
            // Klärung, welcher Programmteil ablaufen soll
            // Clarify which part of program is to be executed
            Console.WriteLine("Bitte wählen Sie 1 für ganzzahige Potenzrechnung und 2 für Zinsberechnung...");
            Console.WriteLine("Please select 1 for integer power and 2 for interest calculation");
            string interestPower = Console.ReadLine();

            // "1" bedeutet Potenzrechner
            // "1" is power calculation
            if (interestPower == "1")
            {
                Console.Title = "Potenzrechner // Power Calculation";
                // Handling der Benutzereingaben
                // Handling user input
                Console.WriteLine("Bitte geben Sie die Basiszahl ein:");
                Console.WriteLine("Please enter base value:");
                int baseValue = int.Parse(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie den Exponenten ein:");
                Console.WriteLine("Please enter exponent");
                int exponent = int.Parse(Console.ReadLine());

                //---------------------------------------------------------------------------------------------
                // Todo
                // Sonderfall beachten: x^0 ergibt immer 1!
                // Bei allen anderen Fällen Ergebnis mit While-Schleife ermitteln
                // Hinweis: Beachten, wie oft die Schleife durchgeführt werden muss
                // Schleifenbasierte Berechnung mit "*=" durchführen
                // Ergebnis an den Nutzer ausgeben
                //---------------------------------------------------------------------------------------------
                // Todo
                // Take care of special case: x^0 = 1!
                // Calculate result through while loop otherwise
                // Attention: Keep the number of loops in mind
                // Calculate using "*=" 
                // Print result in console
                //---------------------------------------------------------------------------------------------

            }

            // "2" bedeutet Zinsrechnung
            // "2" is interest calculation
            else if (interestPower == "2")
            {                
                Console.Title = "Zinsrechner // Interest calculation";
                // Handling der Benutzereingaben
                // Handling user input
                Console.WriteLine("Bitte geben Sie das Basiskapital ohne Eurozeichen an:");
                Console.WriteLine("Please enter base capital without Euro sign:");

                //---------------------------------------------------------------------------------------------
                // Todo
                // Variable für das Basiskapital (int) anlegen und Wert ermitteln
                //---------------------------------------------------------------------------------------------                
                // Todo
                // Declare variable for base capital (int) and assign value
                //---------------------------------------------------------------------------------------------

                Console.WriteLine("Bitte geben Sie den Zinssatz in Prozent an:");
                Console.WriteLine("Please enter interest rate as a percentage:");
                //---------------------------------------------------------------------------------------------
                // Todo
                // Variable für den Zinssatz (double) anlegen und Wert ermitteln
                //---------------------------------------------------------------------------------------------                
                // Todo
                // Declare variable for interest rate (double) and assign value
                //---------------------------------------------------------------------------------------------

                Console.WriteLine("Bitte geben Sie die Laufzeit in Jahren an:");
                Console.WriteLine("Please enter periods in years:");
                //---------------------------------------------------------------------------------------------
                // Todo
                // Variable für die Laufzeit in Jahren anlegen und Wert ermitteln
                //---------------------------------------------------------------------------------------------
                // Todo
                // Declare variable for periods in years and assign value
                //---------------------------------------------------------------------------------------------

                double result = 0;
                //---------------------------------------------------------------------------------------------
                // Todo
                // Mittels einer For-Schleife das Endkapital ermitteln
                // Hinweis: Bildung eines Multiplikators mit der Form (1+ Zinssatz/100) sinnvoll
                // Berechnung mittels "*=" auf Variable "result"
                //---------------------------------------------------------------------------------------------
                // Todo
                // Calculate final capital using for-loop
                // Attention: Consider using (1+ interest rate/100) for calculation 
                // Calculate using "*=" for variable "result"
                //---------------------------------------------------------------------------------------------

                //---------------------------------------------------------------------------------------------
                // Todo
                // Formatierung des Ergebnis-Wertes fehlt. Geben Sie zwei Nachkomma-Stellen an!
                //---------------------------------------------------------------------------------------------
                // Todo
                // Formate result is missing. Keep formate with two decimal places
                //---------------------------------------------------------------------------------------------
                Console.WriteLine("Das Kapital am Ende der Laufzeit beträgt " + result.ToString() + " Euro.");
                Console.WriteLine("Final capital at the end of the periods is " + result.ToString() + " Euro.");
                Console.ReadLine();
            }
            else
            {
                // Falsche Eingabe
                // Wrong user input
                Console.Title = "Error";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sie haben eine falsche Eingabe durchgeführt.");
                Console.Write("You've entered an incorrect input.");
                Console.ReadLine();
            }
            //---------------------------------------------------------------------------------------------
            // Todo
            // Abfrage, ob der Benutzer einen weiteren Durchgang durchführen soll oder ob das Programm beendet wird
            //---------------------------------------------------------------------------------------------
            // Todo
            // Ase for user input to execute the program again or exit.
            //---------------------------------------------------------------------------------------------
            Console.WriteLine("Möchten Sie eine weitere Berechnung durchführen? j/n");
            Console.WriteLine("Do you want to start another calculation? y/n");

        }
    }
}
