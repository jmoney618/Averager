using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Averager
{
    class AveragerExceptions : Exception
    {
        public static void InvalidInputTypeException()
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
