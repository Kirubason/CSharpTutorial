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
            Mathematics obj = new Mathematics();
            int Total = obj.Addition(14, 12);
            Console.WriteLine("The total is " + Total);
        }
    }
}
