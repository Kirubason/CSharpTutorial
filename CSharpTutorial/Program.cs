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
            ReadonlyConstantDemo obj = new ReadonlyConstantDemo("Physics");
            Console.WriteLine(obj.Subject);
            Console.WriteLine(ReadonlyConstantDemo.pi);
        }
        
    }
}
