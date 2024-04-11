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
            string states = Country.States("Tamil nadu","Kerala");
            Console.WriteLine(states + "are major states in India");
        }
        
    }
}
