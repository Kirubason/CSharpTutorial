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
            foreach (string Country in PrintCountry())
            {
                Console.WriteLine(Country);
            }
            IEnumerable<string> PrintCountry()
            {
                
                yield return "India";
                yield return "US";
                yield return "UK";
                yield return "Europe";
            }
        }
        
    }
}
