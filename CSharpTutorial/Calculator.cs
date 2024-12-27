using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
	public delegate void Calculate(int x, int y);
	public class Calculator
	{
		public void Add(int x, int y)
		{
			Console.WriteLine("The addition of two value is {0}", + (x + y));
		}
		public void Subtract(int x, int y)
		{
			Console.WriteLine("The subtraction of two values is {0}", + (x - y));
		}

		public void Multiply(int x, int y)
		{
			Console.WriteLine("The multiplication of two values is {0}", + (x * y));
		}

		public void Divide(int x, int y)
		{
			if (y != 0)
			{
				Console.WriteLine("The division of two values is {0}", + (x / y));
			}
			else
			{
				Console.WriteLine("Division by zero is not allowed.");
			}
		}

	}
}
