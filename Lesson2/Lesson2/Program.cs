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
            TypeAccount secondClientTypeAccount = TypeAccount.current;
            BankAccount secondBankAccount = new BankAccount(secondClientBalance, secondClientTypeAccount);
            secondBankAccount.PrintAccountInfo();

            TypeAccount thirdClientTypeAccount = TypeAccount.deposit;
            BankAccount thirdBankAccount = new BankAccount(thirdClientTypeAccount);
            thirdBankAccount.PrintAccountInfo();          

            Console.ReadKey();
        }
    }
}
