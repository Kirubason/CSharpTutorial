using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
	public class GenericCollectionDemo
	{
		public void ExampleList()
		{
			Console.WriteLine("Example for Generic List<T>");
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
			numbers.Add(6);
			numbers.RemoveAt(0);
			foreach (int number in numbers)
			{
				Console.WriteLine(number);
			}
			Console.WriteLine();
		}

		public void ExampleDictionary()
		{
			Console.WriteLine("Example for Generic Dictionary<TKey, TValue>");
			Dictionary<int, string> studentGrades = new Dictionary<int, string>
			{
				{ 1, "A" },
				{ 2, "B" },
				{ 3, "A+" }
			};
			foreach (var kvp in studentGrades)
			{
				Console.WriteLine($"Student {kvp.Key}: Grade {kvp.Value}");
			}
			Console.WriteLine();
		}

		public void ExampleSortedList()
		{
			Console.WriteLine("Example for Generic SortedList<TKey, TValue>");
			SortedList<int, string> ranks = new SortedList<int, string>
			{
				{ 3, "Third" },
				{ 1, "First" },
				{ 2, "Second" }
			};
			foreach (var kvp in ranks)
			{
				Console.WriteLine($"{kvp.Key}: {kvp.Value}");
			}
			Console.WriteLine();
		}

		public void ExampleStack()
		{
			//Last-In-First-Out (LIFO)
			Console.WriteLine("Example for Generic Stack<T>");
			Stack<string> books = new Stack<string>();
			books.Push("C# Programming");
			books.Push("Data Structures");
			books.Push("Algorithms");
			books.Pop();
			foreach (var book in books)
			{
				Console.WriteLine(book);
			}
			Console.WriteLine();
		}

		public void ExampleQueue()
		{
			//First-In-First-Out (FIFO)
			Console.WriteLine("Example for Generic Queue<T>");
			Queue<string> vehicles = new Queue<string>();
			vehicles.Enqueue("Car");
			vehicles.Enqueue("Bike");
			vehicles.Enqueue("Bus");
			vehicles.Dequeue();
			foreach (var vehicle in vehicles)
			{
				Console.WriteLine(vehicle);
			}
			Console.WriteLine();
		}

	}
}
