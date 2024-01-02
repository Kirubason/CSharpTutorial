using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class Mathematics
    {
        private int value1, value2;
        public Mathematics(int a, int b)
        {
            value1 = a;
            value2 = b;
        }
        public int Addition()
        {
            return value1 + value2;
        }
        public int Multiplication()
        {
            return value1 * value2;
        }
        public int Subtraction()
        {
            return value1 - value2;
        }
    }
}
