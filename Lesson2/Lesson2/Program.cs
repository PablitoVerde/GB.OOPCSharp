using System;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа банковских счетов");

            BankAccount ba = new BankAccount();

            Console.WriteLine("Введите номер счета");
            ba.AddAccountNumber(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Введите баланс");
            ba.AddBalance(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Введите тип счета: 1. Депозитный 2. Расчетный 3. Кредитный");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                TypeAccount ta = TypeAccount.deposit;
                ba.ChangeTypeAccount(ta);
            }
            else if (i == 2)
            {
                TypeAccount ta = TypeAccount.current;
                ba.ChangeTypeAccount(ta);
            }
            else if (i == 3)
            {
                TypeAccount ta = TypeAccount.credit;
                ba.ChangeTypeAccount(ta);
            }

            Console.WriteLine($"Новый счет: {ba.GetAccountNumber()}. Состояние баланса: {ba.GetAccountBalance()}. Тип счета: {ba.GetTypeAccount()}");

            Console.ReadKey();
        }
    }
}
