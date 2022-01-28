using System;

/*
 * 1. Для класса банковский счет переопределить операторы == и != для сравнения информации в двух счетах. 
 * Переопределить метод Equals аналогично оператору ==, не забыть переопределить метод GetHashCode(). 
 * Переопределить методToString() для печати информации о счете. Протестировать функционирование 
 * переопределенных методов и операторов на простом примере.
 * */

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа банковских счетов");

            double firstClientBalance = 1234;
            BankAccount firstBankAccount = new BankAccount(firstClientBalance);
            Console.WriteLine(firstBankAccount.ToString());

            double secondClientBalance = 5345;
            TypeAccount secondClientTypeAccount = TypeAccount.Current;
            BankAccount secondBankAccount = new BankAccount(secondClientBalance, secondClientTypeAccount);
            Console.WriteLine(secondClientBalance.ToString());

            TypeAccount thirdClientTypeAccount = TypeAccount.Deposit;
            BankAccount thirdBankAccount = new BankAccount(thirdClientTypeAccount);
            Console.WriteLine(thirdBankAccount.ToString());


            firstBankAccount.AddBalance(100);
            Console.WriteLine(firstBankAccount.ToString());
            firstBankAccount.WithdrawFromBalance(400);
            Console.WriteLine(firstBankAccount.ToString());
            firstBankAccount.WithdrawFromBalance(5000);

            bool b = firstBankAccount.Equals(secondBankAccount);
            Console.WriteLine($"Сравнение двух счетов: {b}");

            bool c = firstBankAccount != secondBankAccount;
            Console.WriteLine($"Сравнение двух счетов: {c}");

            bool d = firstBankAccount == secondBankAccount;
            Console.WriteLine($"Сравнение двух счетов: {d}");

            Console.WriteLine($"{firstBankAccount.GetHashCode()}");
            Console.ReadKey();
        }
    }
}
