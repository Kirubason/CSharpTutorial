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
            BankAccount obj = new BankAccount(10000);
            obj.Deposit = 100;
            Console.WriteLine("The current account balance after credited 100 is " + obj.Deposit);

            Console.WriteLine("The total account balance is " + obj.AccountBalance);
            obj.CloseAccount = 0;
            Console.WriteLine("The total account balance is " + obj.AccountBalance);
        }
    }
}
