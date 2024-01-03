using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class BankAccount
    {
        #region variables
        private int Currentbalance;
        #endregion
        #region properties
        public int Deposit
        {
            get
            {
                return Currentbalance;
            }
            set
            {
                Currentbalance += value;
            }
        }
        public int AccountBalance
        {
            get
            {
                return Currentbalance;
            }
        }
        public int CloseAccount
        {
            set
            {
                Currentbalance = value;
            }
        }
        #endregion
        #region methods
        public BankAccount(int initialAmount)
        {
            Currentbalance = initialAmount;
        }
        #endregion
    }
}
