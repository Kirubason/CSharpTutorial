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
            Console.WriteLine(College.CollegeMethod());
            Console.WriteLine(College.CollegeMethod());
            College clg1 = new College();
            Console.WriteLine(College.CollegeMethod());
            College clg2 = new College();
            Console.WriteLine(College.CollegeMethod());
        }
    }
}
