using System;
using System.Collections.Generic;
using System.Text;

/*
Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип). 
Предусмотреть методы для доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.
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
        private int accountNumber;
        private double balance;
        private TypeAccount typeAccount;

        public void AddAccountNumber(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public int GetAccountNumber()
        {
            return this.accountNumber;
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
