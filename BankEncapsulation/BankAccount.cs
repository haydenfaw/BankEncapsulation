using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public void Deposit(double depositAmount)
        {
            balance += depositAmount;
        }
        public void Withdraw(double withdrawAmount)
        {
            balance -= withdrawAmount;
        }
        //public void Withdraw()
        //{
        //    bool isParseable = false;
        //    Console.WriteLine($"Please enter the value you wish to withdraw:");
        //    isParseable = double.TryParse(Console.ReadLine(), out double withdrawAmount);
        //    if (withdrawAmount > balance && isParseable == true)
        //    {
        //        balance -= withdrawAmount;
                
        //    }
        //    if (isParseable == false)
        //    {
        //        int i = 0;
        //        while (i == 0)
        //        {
        //            Console.WriteLine($"Sorry, but that amount is larger than the value in your account. Please enter a value less than {balance}");
        //            isParseable = double.TryParse(Console.ReadLine(), out withdrawAmount);
        //            if(isParseable == true && withdrawAmount > balance)
        //            {
        //                balance -= withdrawAmount;
        //                i++;
        //            }
        //        }

        //    }
        //}

         public void GetBalance()
        {
            Console.WriteLine($"Your current balance is ${balance}");
        }
        public bool IsWithdrawPossible(double withdrawAmount)
        {
            if (withdrawAmount > balance)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
