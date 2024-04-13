using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class Country
    {
        //Change this variable access modifier and test
        public static string CountryName = "India";
        public void CountryMethod()
        {
            Console.WriteLine("My country is" + CountryName);
        }
    }
    public class state : Country
    {
        public void StateMethod()
        {
            Console.WriteLine("My country is" + CountryName);
        }
    }
}

