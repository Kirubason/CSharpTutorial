using System;
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
            try
            {
                ExceptionMethod1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        public static void ExceptionMethod1()
        {
            try
            {
                ExceptionMethod2();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void ExceptionMethod2()
        {
            Console.WriteLine("Please enter integer value");
            int value = Convert.ToInt32(Console.ReadLine());
        }
    }
}
