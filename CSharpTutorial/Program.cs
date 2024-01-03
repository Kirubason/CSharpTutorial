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
            OverloadingExample obj1 = new OverloadingExample();
            Console.WriteLine("The Addition is " + obj1.Addition(5,4));

            OverridingExampleParent obj2 = new OverridingExampleParent();
            obj2.Job("Doctor");

            OverridingExampleChild obj3 = new OverridingExampleChild();
            obj3.Job("Studies");
        }
    }
}
