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
			Fruits obj = new Fruits(23, true, new string[] { "Mango", "Orange", "Banana" });
			Console.WriteLine(obj.FruitPrice);
			Console.WriteLine(obj.IsFruitAvailable);
			Console.WriteLine(obj.FruitsList[0]);
		}

		public struct Fruits
		{
			public int FruitPrice;
			public bool IsFruitAvailable;
			public string[] FruitsList
			{
				get;set;

			}
			public Fruits(int FruitPrice, bool IsFruitAvailable, string[] FruitsList)
			{
				this.FruitPrice = FruitPrice;
				this.IsFruitAvailable = IsFruitAvailable;
				this.FruitsList = FruitsList;
			}
		}
	}
}
