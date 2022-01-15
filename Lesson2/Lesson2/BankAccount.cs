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
*/


namespace Lesson2
{
    public enum TypeAccount
    {
        deposit,
        current,
        credit
    }

    public class BankAccount
    {
        static int AccountNumber = 1;

        private int clientAccountNumber;
        private double balance;
        private TypeAccount typeAccount;

        public BankAccount(double balance)
        {
            clientAccountNumber = GenerateAccountNumber();
            Balance = balance;
            TypeAccount = TypeAccount.current;
        }

        public BankAccount(TypeAccount typeAccount)
        {
            clientAccountNumber = GenerateAccountNumber();            
            TypeAccount = typeAccount;          
            Balance = 0;
        }

        public BankAccount(double balance, TypeAccount typeAccount)
        {
            clientAccountNumber = GenerateAccountNumber();
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
            balance += sum;
        }


        public int ClientAccountNumber { get; set; }
        public double Balance { get; set; }
        public TypeAccount TypeAccount { get; set; }

        public int GetAccountNumber()
        {
            return clientAccountNumber;
        }

        public double GetAccountBalance()
        {
            return this.balance;
        }

        public void PrintAccountInfo()
        {
            string _typeAccount;

            if (TypeAccount == TypeAccount.deposit)
                _typeAccount = "Депозитный";
            else if (TypeAccount == TypeAccount.current)
                _typeAccount = "Расчетный";
            else if (TypeAccount == TypeAccount.credit)
                _typeAccount = "Кредитный";
            else
                _typeAccount = "Тип счета не определен";

            Console.WriteLine($"Новый счет: {clientAccountNumber}. Состояние баланса: {GetAccountBalance()}. Тип счета: {_typeAccount}");
        }

    }
}
