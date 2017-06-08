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
            double[] numbers = { };

            while (true)
            {
                try
                {
                    // Ask user to enter a number or quit
                    Console.Write("Enter a number or type \'done\' to get the average: ");
                    var input = Console.ReadLine();

                    // Validate is user wants to quit
                    if (input.ToLower() == "done" && numbers.Length == 0)
                    {
                        Console.WriteLine("You really didn\'t want to use this app did you?");
                        Console.Write("Enter any key to quit.");
                        return;
                    }
                    else
                    {

                    }
                }
                catch
                {

                }
            }
        }

        public double Average(double[] numbers)
        {
            double total = 0.0;
            double average = 0.0;
            foreach(double number in numbers)
            {
                total += number;
            }

            return average = total / numbers.Length;
        }
    }
}