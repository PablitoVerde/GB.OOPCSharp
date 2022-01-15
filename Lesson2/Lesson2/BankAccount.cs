using System;
using System.Collections.Generic;
using System.Text;

/*
1. Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип). 
Предусмотреть методы для доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.

2. Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным. 
Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.
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
        static int accountNumber = 00000001;

        private int clientAccountNumber;
        private double balance;
        private TypeAccount typeAccount;

        public void AddAccountNumber()
        {
            clientAccountNumber = accountNumber + 1;
        }

        public int GetAccountNumber()
        {
            return this.clientAccountNumber;
        }
        public void AddBalance(double sum)
        {
            balance += sum;
        }

        public double GetAccountBalance()
        {
            return this.balance;
        }

        public void ChangeTypeAccount(TypeAccount typeAccount)
        {
            this.typeAccount = typeAccount;
        }

        public string GetTypeAccount()
        {
            if (typeAccount == TypeAccount.deposit)
                return "Депозитный";
            if (typeAccount == TypeAccount.current)
                return "Расчетный";
            if (typeAccount == TypeAccount.credit)
                return "Кредитный";
            else
                return "Тип счета не определен";
        }

    }
}
