using System;
using System.Collections;
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

			Calculator obj = new Calculator();
			Calculate calculate = new Calculate(obj.Divide); // Single cast delegate
			calculate += obj.Multiply;
			calculate += obj.Subtract; // Multi cast delegate
			calculate += delegate(int x, int y) {
				Console.WriteLine("The addition of two value is {0}", +(x + y));
			}; // Anonymous delegate
			calculate(40, 5);
		}

	}
}
