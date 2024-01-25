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
            Console.WriteLine(ExceptionMethod());
        }
        public static string ExceptionMethod()
        {
            int[] ArrInt = new int[3];
            try
            {
                Console.WriteLine("Please enter the index position");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the value");
                int value = Convert.ToInt32(Console.ReadLine());

                ArrInt[index] = value;
                return "No exception, The value in the index position " + index + " is " + value;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return "There is an exception while calling the method";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "There is an exception while calling the method";
            }
            finally
            {
                Console.WriteLine("Finally method executed");
            }
        }
    }
}
