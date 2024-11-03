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
			Console.WriteLine("The maximum GC generation is " + GC.MaxGeneration);

			Program obj = new Program();
			Console.WriteLine("The generation of obj is " + GC.GetGeneration(obj));
			Console.WriteLine("The total allocated memory before GC run is " + GC.GetTotalMemory(false));

			GC.Collect(0);
			Console.WriteLine("The total allocated memory after GC run is " + GC.GetTotalMemory(false));
		}
	}
}
