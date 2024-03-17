using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public static class ExtensionMethodClass
    {
        public static string IsEvenOrOdd(this int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
    }
}
