using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            RefOutDemo obj = new RefOutDemo();
            int a = 5;
            int b = 10;
            Console.WriteLine("Previous value of a = " + a);
            Console.WriteLine("Previous value of b = " + b);

            Console.WriteLine(obj.Addition(ref a,out b));

            Console.WriteLine("After value of a = "+ a);
            Console.WriteLine("After value of b = "+ b);
        }
        
    }
}
