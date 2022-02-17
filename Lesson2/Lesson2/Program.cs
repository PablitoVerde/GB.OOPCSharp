using System;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа банковских счетов");

            double firstClientBalance = 1234;
            BankAccount firstBankAccount = new BankAccount(firstClientBalance);
            firstBankAccount.PrintAccountInfo();

            double secondClientBalance = 5345;
            TypeAccount secondClientTypeAccount = TypeAccount.Current;
            BankAccount secondBankAccount = new BankAccount(secondClientBalance, secondClientTypeAccount);
            secondBankAccount.PrintAccountInfo();

            TypeAccount thirdClientTypeAccount = TypeAccount.Deposit;
            BankAccount thirdBankAccount = new BankAccount(thirdClientTypeAccount);                   
            thirdBankAccount.PrintAccountInfo();


            firstBankAccount.AddBalance(100);
            firstBankAccount.PrintAccountInfo();
            firstBankAccount.WithdrawFromBalance(400);
            firstBankAccount.PrintAccountInfo();
            firstBankAccount.WithdrawFromBalance(5000);

            secondBankAccount.WithdrawFromBalance(5000);
            secondBankAccount.PrintAccountInfo();

            firstBankAccount.MakeTransaction(secondBankAccount, 300);
            firstBankAccount.PrintAccountInfo();
            secondBankAccount.PrintAccountInfo();

            firstBankAccount.MakeTransaction(secondBankAccount, 50);
            firstBankAccount.PrintAccountInfo();
            secondBankAccount.PrintAccountInfo();

            Console.ReadKey();
        }
    }
}
