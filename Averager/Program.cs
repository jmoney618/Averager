using System;
using System.Collections.Generic;
using static System.Console;

namespace Averager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list that will store numbers the user inputs
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
                        WriteLine("You really didn\'t want to use this app did you?");
                        Write("Enter any key to quit.");
                        break;
                    }
                    else if (input.ToLower() == "done")
                    {
                        WriteLine("Thank you for using the Averager!");
                        Write("Hit any key to quit.");
                        break;
                    }
                    else if (input.ToLower() != "done" || input is string )
                    {
                        throw AveragerExceptions.InvalidInputTypeException();
                    }
                    else
                    {
                        // Convert input into a decimal number and add it to the List
                        numbers.Add(double.Parse(input));
                        // Call CalcAverage method and output result to the user
                        WriteLine("The average for the {0} numbers entered is {1}.", numbers.Count, Calculate.CalcAverage(numbers));
                    }
                }
                catch (FormatException)
                {
                    WriteLine("That was not a valid entry.");
                }
            }
            ReadLine();
        }
    }
}