using System;
using System.Collections.Generic;
using System.Text;

/*
1. Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип). 
Предусмотреть методы для доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.

2. Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным. 
Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.

3. В классе банковский счет удалить методы заполнения полей. Вместо этих методов создать конструкторы. 
Переопределить конструктор по умолчанию, создать конструктор для заполнения поля баланс, конструктор для 
заполнения поля тип банковского счета, конструктор для заполнения баланса и типа банковского счета. 
Каждый конструктор должен вызывать метод, генерирующий номер счета.

4. В классе все методы для заполнения и получения значений полей заменить на свойства. Написать тестовый пример.

5. * Добавить в класс счет в банке два метода: снять со счета и положить на счет. Метод снять со счета проверяет, 
возможно ли снять запрашиваемую сумму, и в случае положительного результата изменяет баланс.
*/

/* Урок 3
 * 1. В класс банковский счет, созданный в упражнениях, добавить метод, который переводит деньги с одного счета на другой. 
 * У метода два параметра: ссылка на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.
 */


namespace Lesson2
{
    public enum TypeAccount
    {
        Deposit,
        Current,
        Credit
    }

    public class BankAccount
    {
        private static int AccountNumber = 1;

        private int clientAccountNumber;
        private double balance;
        private TypeAccount typeAccount;

        public BankAccount(double balance)
        {
            ClientAccountNumber = GenerateAccountNumber();
            Balance = balance;
            TypeAccount = TypeAccount.Current;
        }

        public BankAccount(TypeAccount typeAccount)
        {
            ClientAccountNumber = GenerateAccountNumber();
            TypeAccount = typeAccount;
            Balance = 0;
        }

        public BankAccount(double balance, TypeAccount typeAccount)
        {
            ClientAccountNumber = GenerateAccountNumber();
            Balance = balance;
            TypeAccount = typeAccount;
        }

        static private int GenerateAccountNumber()
        {
            AccountNumber++;
            return AccountNumber;
        }

        /// <summary>
        /// Добавить баланс на счет
        /// </summary>
        /// <param Сумма="sum"></param>
        public void AddBalance(double sum)
        {
            double balance = Balance;
            balance = balance + sum;
            Balance = balance;
        }

        /// <summary>
        /// Снять деньги со счета
        /// </summary>
        /// <param Сумма="sum"></param>
        public void WithdrawFromBalance(double sum)
        {
            if (Balance > sum)
            {
                double withdraw = -sum;
                AddBalance(withdraw);
            }
            else
                Console.WriteLine("Произошла ошибка. Снятие денег невозможно. Недостаточно средств на счете");
        }


        public int ClientAccountNumber { get { return clientAccountNumber; } private set { clientAccountNumber = value; } }
        public double Balance { get; set; }
        public TypeAccount TypeAccount { get; set; }

        /// <summary>
        /// Метод по выводу сведений о счете на экран
        /// </summary>
        public void PrintAccountInfo()
        {
            string _typeAccount;

            switch (TypeAccount)
            {
                case TypeAccount.Deposit:
                    _typeAccount = "Депозитный";
                    break;
                case TypeAccount.Current:
                    _typeAccount = "Расчетный";
                    break;
                case TypeAccount.Credit:
                    _typeAccount = "Кредитный";
                    break;
                default:
                    _typeAccount = "Тип счета не определен";
                    break;

            }

            Console.WriteLine($"Новый счет: {ClientAccountNumber}. Состояние баланса: {Balance}. Тип счета: {_typeAccount}");
        }

        /// <summary>
        /// Метод по переводу денег со счета. 
        /// </summary>
        /// <param Источник перевода="bankAccountSource"></param>
        /// <param Сумма="sum"></param>
        public void MakeTransaction (BankAccount bankAccountSource, double sum)
        {
            if (bankAccountSource.Balance>=sum)
            {
                bankAccountSource.Balance -= sum;
                Balance += sum;
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете. Операция не произведена");
            }
        }

    }
}
