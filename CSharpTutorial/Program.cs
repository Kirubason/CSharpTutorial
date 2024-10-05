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
			Fruits obj = new Fruits(23, true, "Mango");
			Console.WriteLine(obj.FruitName + " is " + (obj.IsFruitAvailable ? "Availeble" : "Not Available") + " and Its price is " +obj.FruitPrice);
			obj.SellFruit();
		}

		public struct Fruits
		{
			public int FruitPrice;
			public bool IsFruitAvailable;
			public string FruitName
			{
				get;set;

			}
			public Fruits(int FruitPrice, bool IsFruitAvailable, string FruitName)
			{
				this.FruitPrice = FruitPrice;
				this.IsFruitAvailable = IsFruitAvailable;
				this.FruitName = FruitName;
			}
			public void SellFruit()
			{
				Console.WriteLine("Fruit is sold");
			}
		}
	}
}
