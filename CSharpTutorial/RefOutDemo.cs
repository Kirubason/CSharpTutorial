using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class RefOutDemo
    {
        public int Addition(ref int a , out int b)
        {
            b = 15;
            return a + b;
        }
    }
}
