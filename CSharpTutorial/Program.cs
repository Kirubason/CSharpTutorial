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
            foreach (string Country in PrintCountry('u'))
            {
                Console.WriteLine(Country);
            }
            
            Console.ReadLine();
        }
        static IEnumerable<string> PrintCountry(char chr)
        {
            List<string> countries = new List<string>() {
                "India","US","UK","Europe"};
            //List<string> countriesWithChar = new List<string>();
            for (int i = 0; i < countries.Count; i++)
            {
                if(countries[i].ToLower().Contains(chr))
				{
                    Console.WriteLine(i.ToString());
                    yield return countries[i];
                    //countriesWithChar.Add(countries[i]);
                }
            }
            //return countriesWithChar;
        }
    }
}
