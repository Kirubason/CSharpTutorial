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
            foreach (string Country in PrintCountry(4))
            {
                Console.WriteLine(Country);
            }
            IEnumerable<string> PrintCountry(int count)
            {
                List<string> countries = new List<string>() {
                "India","US","UK","Europe"};
                for(int i =0;i<count;i++)
                {
                    yield return countries[i];
                }
            }
        }
        
    }
}
