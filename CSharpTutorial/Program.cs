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
            string[] states = new string[] { "Tamil nadu", "Kerala", "Andhra", "Bihar" };
            Console.WriteLine(Country.States(states) + "are major states in India");
        }
        
    }
}
