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
            GenericCollectionDemo genericCollectionDemo = new GenericCollectionDemo();
            NonGenericCollectionDemo nonGenericCollectionDemo = new NonGenericCollectionDemo();

            genericCollectionDemo.ExampleList();
            nonGenericCollectionDemo.ExampleArrayList();
            Console.WriteLine("--------------------------");


			genericCollectionDemo.ExampleDictionary();
            nonGenericCollectionDemo.ExampleHashtable();
			Console.WriteLine("--------------------------");

			genericCollectionDemo.ExampleSortedList();
            nonGenericCollectionDemo.ExampleSortedList();
			Console.WriteLine("--------------------------");

			genericCollectionDemo.ExampleStack();
            nonGenericCollectionDemo.ExampleStack();
			Console.WriteLine("--------------------------");

			genericCollectionDemo.ExampleQueue();
			nonGenericCollectionDemo.ExampleQueue();
			Console.WriteLine("--------------------------");
		}

	}
}
