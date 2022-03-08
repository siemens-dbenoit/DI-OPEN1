using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.Title = "Taschenrechner // Calculator";
            Console.WriteLine("Bitte geben Sie Zahl 1 ein:");
            Console.WriteLine("Please enter number 1:");
            //number1 = Int32.Parse(Console.ReadLine());
            var result = Int32.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Bitte geben Sie Zahl 2 ein:");
            Console.WriteLine("Please enter number 2:");
            number2 = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Die Zahlen lauten " + number1.ToString() + " und " + number2.ToString());
            Console.WriteLine("The numbers are " + number1.ToString() + " and " + number2.ToString());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Addition ergibt " + (number1 + number2).ToString());
            Console.WriteLine("Addition equals " + (number1 + number2).ToString());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Subtraktion ergibt " + (number1 - number2).ToString());
            Console.WriteLine("Subtraction equals " + (number1 - number2).ToString());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Multiplikation ergibt " + (number1 * number2).ToString());
            Console.WriteLine("Multiplication equals " + (number1 * number2).ToString());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Division ergibt " + (number1 / number2).ToString());
            Console.WriteLine("Division equals " + (number1 / number2).ToString());

            Console.ReadLine();
        }
    }
}
