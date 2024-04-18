using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public partial class Country
    {
        public static string CountryName = "India";
        public void CountryMethod()
        {
            Console.WriteLine("My country is" + CountryName);
        }
    }
    public sealed partial class Country
    {
        public static string ParentCountryName = "India";
        public void ParentCountryMethod()
        {
            Console.WriteLine("My Parent country is" + ParentCountryName);
        }
    }
    public class State : Country
    {
        public static string StateName = "Tamilnadu";
        public void StateMethod()
        {
            Console.WriteLine("My State is" + StateName);
        }
    }
}

