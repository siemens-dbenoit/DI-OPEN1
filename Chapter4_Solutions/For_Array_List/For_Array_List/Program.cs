using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------
            // Todo:
            // Umschließen Sie die gesamte Funktion mit einer While (true), 
            // um so mehrfaches Ausführen der Funktion 
            // ohne Beenden des Programms zu ermöglichen
            //---------------------------------------
            // Todo:
            // Surround program with a while Loop (true)
            // to execute program multiple times without break         
            //---------------------------------------
            while (true)
            {
                #region Field declaration
                //---------------------------------------
                // Todo:
                // Deklarieren Sie zwei Felder: 
                // Ein Array mit 100 Variablen des Datentyps Int
                // Eine Liste mit dem Datentyp Int und derzeit noch keinen Einträgen
                //---------------------------------------            
                // Todo:
                // Declare two fields:
                // Array of 100 variables of type int
                // List of variables of type int with 0 entries
                //---------------------------------------
                int[] arrayOfIntegers = new int[100];
                List<int> listOfIntegers = new List<int>();
                #endregion

                #region Start entry
                // Benutzer soll zu Beginn auswählen, ob er eine Liste oder ein Array möchte.
                // User should be able to select list or array at beginning 
                Console.WriteLine("Bitte wählen Sie: 1 für Array oder 2 für Listenmethode");
                Console.WriteLine("Please select: 1 for array or 2 for list method!");
                string methodAnswerString = Console.ReadLine();
                // Wenn Benutzer etwas anderes eingibt (also keine 1 oder 2), dann wird das Programm erneut gestartet
                // Program will be restarted if user input differs from 1 or 2
                if (!methodAnswerString.Equals("1") && !methodAnswerString.Equals("2"))
                {
                    Console.WriteLine("Sie haben einen falschen Wert eingegeben. Das Programm wird erneut gestartet.");
                    Console.WriteLine("You've entered an incorrect value. Program will be restarted.");
                    Console.ReadLine();
                    Console.Clear();
                    //---------------------------------------
                    // Todo:
                    // aktuellen Schleifendurchlauf beenden 
                    // und so einen Neustart des Programms initiieren                   
                    //---------------------------------------
                    // Todo:
                    // break running loop cycle 
                    // to initialize program restart
                    //---------------------------------------
                    continue;
                }
                #endregion

                #region Function selection
                // Benutzer soll anschließend angeben, ob er X^1, X^2 oder X^3 berechnen lassen möchte
                // Ask for user input to calculate either X^1, X^2 or X^3
                Console.WriteLine("Möchten Sie die Funktion");
                Console.WriteLine("(1) x ^1");
                Console.WriteLine("(2) x ^2 oder");
                Console.WriteLine("(3) x ^3 zur Berechnung heranziehen?");
                Console.WriteLine("Do you want to use function");
                Console.WriteLine("(1) x ^1");
                Console.WriteLine("(2) x ^2 or");
                Console.WriteLine("(3) x ^3 to calculate values?");

                string functionAnswerString = Console.ReadLine();
                // Gibt der Benutzer einen anderen Wert als 1, 2 oder 3 an, wird das Programm aufgrund von Falscheingaben erneut gestartet
                // Program will be restartet if user input differs from 1,2 or 3. 
                if (!functionAnswerString.Equals("1") & !functionAnswerString.Equals("2") & !functionAnswerString.Equals("3"))
                {
                    Console.WriteLine("Sie haben eine falsche Eingabe getätigt. Bitte wählen Sie nur 1, 2 oder 3.");
                    Console.WriteLine("Das Programm wird neu gestartet.");
                    Console.WriteLine("You've entered an incorrect input. Please select from 1, 2, 3.");
                    Console.WriteLine("Program will be restarted");
                    //---------------------------------------
                    // Todo:
                    // aktuellen Schleifendurchlauf beenden 
                    // und so einen Neustart des Programms initiieren
                    //---------------------------------------               
                    // Todo:
                    // break running loop cycle 
                    // to initialize program restart
                    //---------------------------------------
                    continue;
                }
                #endregion

                Console.WriteLine("--------------------------");

                #region Calculation of values
                // Wenn die Eingabe der Listenmethode ein "Array" war, wird das Array befüllt
                // If selection of listing method is array, the array will be filled
                if (methodAnswerString.Equals("1"))
                {
                    Console.WriteLine("Array-Berechnung findet statt...");
                    Console.WriteLine("Array method will be executed...");
                    // Die ersten 100 (0 <= x <= 99) Ergebnisse sollen in das entsprechende Element geschrieben werden
                    // The first 100 values (0 <= x <= 99) are to be stored in the corresponding element
                    //---------------------------------------
                    // Todo:
                    // ArrayOfIntegers mit Werten befüllen
                    // Auswahl der Funktionsvorschrift mittels FunctionAnswerString
                    //---------------------------------------                
                    // Todo:
                    // Fill ArrayOfIntegers with values
                    // Select function according to FunctionAnswerString
                    //---------------------------------------
                    for (int arrayIndex = 0; arrayIndex <= 99; arrayIndex++)
                    {

                        if (functionAnswerString.Equals("1"))
                        {
                            arrayOfIntegers[arrayIndex] = arrayIndex;
                        }
                        else if (functionAnswerString.Equals("2"))
                        {
                            arrayOfIntegers[arrayIndex] = arrayIndex * arrayIndex;
                        }
                        else
                        {
                            arrayOfIntegers[arrayIndex] = arrayIndex * arrayIndex * arrayIndex;
                        }
                    }
                }
                else
                {
                    // Wenn die Eingabe 2 war wird die Liste zur Berechnung herangezogen
                    // Auswahl kann hier nur 2 sein, da alles andere bereits bei der eigentlichen Auswahl abgelehnt wurde
                    // If input was 2 the list method will be selected to calculate
                    // Selection can be 2 only since other input has been filtered in previous selection
                    Console.WriteLine("Listenberechnung findet statt...");
                    Console.WriteLine("List method will be executed...");
                    //---------------------------------------
                    // Todo:
                    // ListOfIntegers mit Werten befüllen
                    // Auswahl der Funktionsvorschrift mittels FunctionAnswerString
                    //---------------------------------------
                    // Todo:
                    // Fill ListOfIntegers with values
                    // Select function according to FunctionAnswerString
                    //---------------------------------------
                    for (int listIndex = 0; listIndex <= 99; listIndex++)
                    {
                        // Je nach Wahl der zu berechnenden Funktion werden Listenelemente mit dem jeweiligen Wert angelegt
                        if (functionAnswerString.Equals("1"))
                        {
                            listOfIntegers.Add(listIndex);
                        }
                        else if (functionAnswerString.Equals("2"))
                        {
                            listOfIntegers.Add(listIndex * listIndex);
                        }
                        else
                        {
                            listOfIntegers.Add(listIndex * listIndex * listIndex);
                        }

                    }
                    // Die ersten 100 (0<=x<=99 e N) Ergebnisse sollen in das entsprechende Element geschrieben werden
                }
                Console.WriteLine("fertig.");
                Console.WriteLine("done.");
                #endregion

                #region Output
                // Der Benutzer soll angeben, für welches Geradzahlige x er den Wert bekommen möchte
                // Hierfür aus Einfachheitsgründen keine Prüfung der Eingabe
                // User picks even number x of which value is printed
                // No need for additional checks
                Console.WriteLine("Für welches ganzzahlige x möchten Sie den Wert ausgegeben bekommen?");
                Console.WriteLine("Which even number x should be used to print result");
                int indexOfValueToFind = int.Parse(Console.ReadLine());
                Console.WriteLine("Das Ergebnis lautet ");
                Console.WriteLine("Result equals ");
                // Hatte der Benutzer Arrays gewählt, so muss hier der Wert aus dem Array gelesen werden
                // Ansonsten muss aus der Liste gelesen werden
                // If user selected array the value needs to be read from array
                // Use list otherwise
                if (methodAnswerString.Equals("1"))
                {
                    // Array
                    // Umwandeln von Int nach String ist notwendig zur Ausgabe
                    // Array
                    // Cast value from int to string is necessary
                    //---------------------------------------
                    // Todo:
                    // Rest des Ergebnis-Strings ermitteln
                    // Hier mit Zugriff auf das Array
                    // String-Aufbau lautet "<Ergebnis>."
                    //---------------------------------------                
                    // Todo:
                    // Determine ending of result string
                    // use access of array here
                    // String structure is: "<result>."
                    //---------------------------------------
                    Console.WriteLine(arrayOfIntegers[indexOfValueToFind].ToString() + ".");
                }
                else
                {
                    // Liste
                    // Umwandeln von Int nach String ist notwendig zur Ausgabe
                    // List
                    // Cast value from int to string is necessary
                    //---------------------------------------
                    // Todo:
                    // Rest des Ergebnis-Strings ermitteln
                    // Hier mit Zugriff auf die Liste
                    // String-Aufbau lautet "<Ergebnis>."
                    //---------------------------------------
                    // Todo:
                    // Determine ending of result string
                    // use access of list here
                    // String structure is: "<result>."
                    //---------------------------------------
                    Console.WriteLine(listOfIntegers[indexOfValueToFind].ToString() + ".");
                }
                #endregion

                #region Close
                // Klärung, ob das Programm beendet werden soll
                // Decide whether program needs to be closed
                Console.WriteLine("Soll das Programm beendet werden? j/n");
                Console.WriteLine("Do you want to close the program? y/n");
                string endAnswerString = Console.ReadLine();

                // Benutzer wählt, dass das Programm beendet werden soll
                // User asks to close program
                if (endAnswerString.Equals("j") || endAnswerString.Equals("J") || endAnswerString.Equals("y") || endAnswerString.Equals("Y"))
                {
                    //---------------------------------------
                    // Todo:
                    // Schleife vollständig abbrechen
                    // (aus der Schleife heraus springen, um Programm zu beenden)
                    //---------------------------------------
                    // Todo:
                    // Exit loop
                    // (break loop to close program)
                    //---------------------------------------
                    break;
                }
                Console.ReadLine();
                #endregion
            }
        }
    }
}
