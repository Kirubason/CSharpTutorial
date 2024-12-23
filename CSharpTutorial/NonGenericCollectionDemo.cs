using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
	public class NonGenericCollectionDemo
	{
		public void ExampleArrayList()	
		{
			Console.WriteLine("Example for Non Generic ArrayList");
			ArrayList mixedDataList = new ArrayList { 1, "Hello", 3.14, true };
			mixedDataList.Add("World");
			mixedDataList.RemoveAt(0);
			foreach (var item in mixedDataList)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
		}

		public void ExampleHashtable()
		{
			Console.WriteLine("Example for Non Generic Hashtable");
			Hashtable hashtable = new Hashtable
			{
				{ "One", 1 },
				{ 2, "two" },
				{ true, false }
			};
			foreach (DictionaryEntry entry in hashtable)
			{
				Console.WriteLine($"{entry.Key}: {entry.Value}");
			}
			Console.WriteLine();
		}

		public void ExampleSortedList()
		{
			Console.WriteLine("Example for Non Generic SortedList");
			SortedList sortedList = new SortedList
			{
				{ "C", "Three" },
				{ "A", "One" },
				{ "E", "Two" }
			};
			foreach (DictionaryEntry entry in sortedList)
			{
				Console.WriteLine($"{entry.Key}: {entry.Value}");
			}
			Console.WriteLine();
		}

		public void ExampleStack()
		{
			Console.WriteLine("Example for Non Generic Stack");
			Stack stacks = new Stack();
			stacks.Push("Java");
			stacks.Push(2);
			stacks.Push(false);
			stacks.Pop();
			foreach (var stack in stacks)
			{
				Console.WriteLine(stack);
			}
			Console.WriteLine();
		}

		public void ExampleQueue()
		{
			Console.WriteLine("Example for Non Generic Queue");
			Queue queue = new Queue();
			queue.Enqueue("Java");
			queue.Enqueue(2);
			queue.Enqueue(true);
			queue.Dequeue();

			foreach (var que in queue)
			{
				Console.WriteLine(que);
			}
			Console.WriteLine();
		}

	}
}
