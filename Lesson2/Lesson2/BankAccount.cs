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

        public void AddBalance(double sum)
        {
            double balance = Balance;
            balance = balance + sum;
            Balance = balance;
        }

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

        public override bool Equals(object obj)
        {
            return obj is BankAccount account &&
                   ClientAccountNumber == account.ClientAccountNumber &&
                   Balance == account.Balance &&
                   TypeAccount == account.TypeAccount;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ClientAccountNumber, Balance, TypeAccount);
        }

        static public bool operator ==(BankAccount a, BankAccount b)
        {
            return a.ClientAccountNumber == b.ClientAccountNumber;
        }

        static public bool operator !=(BankAccount a, BankAccount b)
        {
            return !(a.ClientAccountNumber == b.ClientAccountNumber);
        }

        public override string ToString()
        {
            string result;
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

            result = ($"Новый счет: {ClientAccountNumber}. Состояние баланса: {Balance}. Тип счета: {_typeAccount}");
            return result;
        }
    }
}
