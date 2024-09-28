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
			int VegetablePrice = 30; 
			string[] Vegetables = new string[] {"Onion", "Potato"};
			Fruits FruitObj = new Fruits();
			char FirstChar = 'a'; 
			DateTime CurrentDateTime = DateTime.Now;
		}

		public class Fruits
		{
			int FruitPrice = 45;
			bool IsFruitAvailable = true;
		}
	}
}
