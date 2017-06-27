using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Averager
{
    class Calculate
    {
        public static double CalcAverage(List<double> numbers)
        {
            double _total = 0.0;
            double _average = 0.0;
            foreach (double num in numbers)
            {
                _total += num;
            }

            return _average = _total / numbers.Count;
        }
    }
}