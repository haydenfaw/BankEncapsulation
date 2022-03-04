using System;

namespace BankEncapsulation
{
    //Questions:
    //1) Why did original Withdraw() not work below with the commented version in BankAccount? It was not subtracting
    //2) Why was original Getbalance() not printing to the screen?
    public class Program
    {
        static void Main(string[] args)
        {
            var bankAccount1 = new BankAccount();

            bool isParseable = false;

            bankAccount1.GetBalance();

            int i = 0;

            do
            {
                Console.WriteLine($"Please enter 1 for deposit and 2 for withdraw:");
                isParseable = int.TryParse(Console.ReadLine(), out int selection);
                if (selection == 1)
                {
                    bool isParseableDeposit = false;
                    do
                    {
                        Console.WriteLine($"How much would you like to deposit?");
                        isParseableDeposit = double.TryParse(Console.ReadLine(), out double depositAmount);
                        bankAccount1.Deposit(depositAmount);
                    } while (isParseableDeposit == false);
                }
                if (selection == 2)
                {
                    bool isParseableDeposit = false;
                    do
                    {
                        Console.WriteLine($"How much would you like to withdraw?");
                        isParseableDeposit = double.TryParse(Console.ReadLine(), out double withdrawAmount);
                        bankAccount1.Withdraw(withdrawAmount);
                    } while (isParseableDeposit == false);
                    //bankAccount1.Withdraw();
                }
                bankAccount1.GetBalance();

                Console.WriteLine($"Please enter 1 to continue back to the main screen and 2 to exit:");
                bool repeat = int.TryParse(Console.ReadLine(), out int willWeRepeat);
                if (willWeRepeat == 1)
                {
                    i = 0;
                }
                if (willWeRepeat == 2)
                {
                    i = 1;
                }
                while (repeat == false)
                {
                    Console.WriteLine($"Sorry, that is an incorrect option, Please enter 1 to continue back to the main screen and 2 to exit:");
                    repeat = int.TryParse(Console.ReadLine(), out willWeRepeat);
                    if (willWeRepeat == 2)
                    {
                        i = 1;
                    }
                }
            } while (i == 0);
        }
    }
}
