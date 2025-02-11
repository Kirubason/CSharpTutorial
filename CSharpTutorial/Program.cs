using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpTutorial
{
	class Program
	{
		public static async Task Main(string[] args)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();

			Console.WriteLine("Main method execution is started");
			Task washingTask = WashingClothes();
			Task cleaningTask = CleaningHouse();
			Task cookingTask = CookingFood();
			await Task.WhenAll(washingTask, cleaningTask, cookingTask);
			Console.WriteLine("Main method execution is completed");

			sw.Stop();
			Console.WriteLine("Elapsed time " + sw.Elapsed);
			Console.ReadLine();
		}

		public static async Task WashingClothes()
		{
			Console.WriteLine("The washing clothes is started");
			await Task.Delay(3000);
			Console.WriteLine("The washing clothes is Completed");
		}
		public static async Task CleaningHouse()
		{
			Console.WriteLine("The cleaning house is started");
			await Task.Delay(2000);
			Console.WriteLine("The cleaning house is Completed");
		}
		public static async Task CookingFood()
		{
			Console.WriteLine("The cooking food is started");
			await Task.Delay(5000);
			Console.WriteLine("The cooking food is Completed");
		}
	}
}
