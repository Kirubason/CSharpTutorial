using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpTutorial
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Main method execution is started");

			// Normal Flow
			Method1();
			Method1WithResult();

			//Thread
			Thread thread1 = new Thread(Method1);
			thread1.Start();

			//Task
			Task<int> task1 = Task.Run(Method1WithResult);
			int result = task1.Result;
			Console.WriteLine($"Task result: {result}");

			Console.WriteLine("Main method execution is completed");
			Console.ReadLine();
		}

		static void Method1()
		{
			for (int i = 1; i < 5; i++)
			{
				Console.WriteLine($"Thread Method1 execution: {i}");
				Thread.Sleep(1000); // Simulate work with 1-second delay
			}
		}
		static int Method1WithResult()
		{
			int sum = 0;
			for (int i = 1; i < 5; i++)
			{
				Console.WriteLine($"Task MethodWithResult execution: {i}");
				sum += i;
				Thread.Sleep(1000); // Simulate work with 1-second delay
			}
			return sum;

		}
	}
}
