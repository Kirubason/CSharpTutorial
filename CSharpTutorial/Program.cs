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
            string CountryName = null;

            string Output = CountryName ?? "India";

            Console.WriteLine("The country name is " + Output);

            Console.ReadLine();
		}
        
    }
}
