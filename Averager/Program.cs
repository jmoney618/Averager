using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Averager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create array that will store numbers the user inputs
            List<double> numbers = new List<double>();

            while (true)
            {
                try
                {
                    // Ask user to enter a number or quit
                    Console.Write("Enter a number or type \'done\' to get the average: ");
                    var input = Console.ReadLine();

                    // Validate if user wants to quit
                    if (input.ToLower() == "done" && numbers.Count < 1)
                    {
                        Console.WriteLine("You really didn\'t want to use this app did you?");
                        Console.Write("Enter any key to quit.");
                        break;
                    }
                    else if (input.ToLower() == "done")
                    {
                        Console.WriteLine("Thank you for using the Averager!");
                        Console.Write("Hit any key to quit.");
                        break;
                    }
                    else if (input.ToLower() != "done" || !(input is int) || !(input is double) )
                    {
                        throw new InvalidInputTypeException("That is not a valid entry.");
                    }
                    else
                    {
                        // Convert input into a decimal number and add it to the List
                        numbers.Add(double.Parse(input));
                        // Call CalcAverage method and output result to the user
                        Console.WriteLine("The average for the {0} numbers entered is {1}.", numbers.Count, CalcAverage(numbers));
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was not a valid entry.");
                }
            }

            Console.ReadLine();
        }

        public static double CalcAverage(List<double> numbers)
        {
            double _total = 0.0;
            double _average = 0.0;
            foreach(double num in numbers)
            {
                _total += num;
            }

            return _average = _total / numbers.Count;
        }
    }
}