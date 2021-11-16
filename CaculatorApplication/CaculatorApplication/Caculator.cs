using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaculatorApplication
{
    public class Caculator
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public int Addition()
        {
            return Num1 + Num2;
        }
        public int Subtaction()
        {
            return Num1 - Num2;
        }
    }
}
