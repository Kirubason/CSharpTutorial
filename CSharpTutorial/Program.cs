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
			object name = "Micah Tech";
			if(name is string)
			{
				Console.WriteLine("Yes, Name is string data type");
				string strName = name as string;
				Console.WriteLine(strName);
			}
			else
			{
				Console.WriteLine("No, Name is not string data type");
				string strName = name as string;
				Console.WriteLine(strName);
			}

			Console.ReadLine();
		}
	}
}
