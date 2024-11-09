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
			using (FileHandler FileHandlerobj = new FileHandler("C:\\Users\\Kirub\\Desktop\\example.txt"))
			{
				FileHandlerobj.WriteToFile("Hello, World!");
			} // Dispose is called automatically at the end of the using block

			FileHandler FileHandlerobj2 = new FileHandler("C:\\Users\\Kirub\\Desktop\\example.txt");
			GC.Collect(0);
		}

	}
}
