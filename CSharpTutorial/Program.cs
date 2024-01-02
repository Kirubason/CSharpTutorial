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
            Mathematics obj = new Mathematics(23,2);
            Console.WriteLine("The Addition is " + obj.Addition());
            Console.WriteLine("The Multiplication is " + obj.Multiplication());
            Console.WriteLine("The Subtraction is " + obj.Subtraction());
        }
    }
}
