using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------
            // Todo
            // Benutzen Sie die oben gelistete Klasse Random
            // Generieren Sie eine eingegebene Anzahl an Zufallszahlen
            // Speichern Sie diese in eine Liste und geben Sie sie anschließend aus
            //---------------------------------------------------
            // Todo
            // Use the Random class
            // Generate random numbers according to user input
            // Store numbers in a list an print to consol afterwards
            //---------------------------------------------------

            System.Random myRandomGenerator = new Random();
            Console.WriteLine("Bitte geben Sie an, wie viele Zufallszahlen Sie benötigen:");
            Console.WriteLine("Please enter the number of random numbers needed:");
            int anzahl = int.Parse(Console.ReadLine());
            List<int> myList = new List<int>();
            for (int i = 1; i <= anzahl; i++)
            {
                myList.Add(myRandomGenerator.Next(100));
                Console.Write("Zahl mit der Nummer " + String.Format("{0:000}", i) + " lautet: " + String.Format("{0:000}", myList[i-1]) + "\t");
                Console.WriteLine("Random number of count " + String.Format("{0:000}", i) + " equals: " + String.Format("{0:000}", myList[i - 1]));
            }
            Console.ReadLine();
        }    
    }
}
