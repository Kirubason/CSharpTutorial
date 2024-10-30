using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence1 = "My ";
            sentence1 += "name ";
            sentence1 += "is ";
            sentence1 += "Micah Tech";

            Console.WriteLine(sentence1);

            StringBuilder sentence2 = new StringBuilder();
            sentence2.Append("My ");
            sentence2.Append("name ");
            sentence2.Append("is ");
            sentence2.Append("Micah Tech");
            Console.WriteLine(sentence2);

        }
	}
}
