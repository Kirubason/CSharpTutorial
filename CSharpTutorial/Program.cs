﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Break Example");
            for(int i = 0; i <= 5; i++)
            {
                if(i==3)
                {
                    break;
                }
                Console.WriteLine(i);
            }

			Console.WriteLine("Continue Example");
			for (int i = 0; i <= 5; i++)
			{
				if (i == 3)
				{
					continue;
				}
				Console.WriteLine(i);
			}
            Console.ReadLine();
		}
        
    }
}
