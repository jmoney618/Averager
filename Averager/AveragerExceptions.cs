using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Averager
{
    class InvalidInputTypeException : Exception
    {
        private InvalidInputTypeException() : base() { }

        public InvalidInputTypeException(string message) : base(message)
        {

        }

        public InvalidInputTypeException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
