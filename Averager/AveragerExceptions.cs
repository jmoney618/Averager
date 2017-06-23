using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Averager
{
    class AveragerExceptions : Exception
    {
        private AveragerExceptions() : base() { }

        public AveragerExceptions(string message) : base(message) { }

        public AveragerExceptions(string message, Exception inner) : base(message, inner) { }

        public static void InvalidInputTypeException()
        {
            Console.WriteLine("Invalid input type.");
        }
    }
}
