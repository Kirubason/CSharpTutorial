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
            bool IsEqual = Mathematics.IsEqual("Micah", "Micah");
            Console.WriteLine(IsEqual == true ? "The given values are equal" : "The given values are not equal");
        }
        
    }
}
