using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestForCalculator
{
    class Calculator
    {

        public int Addition(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
