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
            string[] months = new string[2];
			months[0] = "January";
			months[1] = "February";
			for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine(months[i]);
            }
		}

	}
}
