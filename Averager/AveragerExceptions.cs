using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Averager
{
    class AveragerExceptions : Exception
    {
        public static Exception InvalidInputTypeException()
        {
            throw new FormatException("Invalid input.");
        }
    }
}
