using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1.Создать класс рациональных чисел. В классе два поля – числитель и знаменатель. Предусмотреть конструктор. 
Определить операторы ==, != (метод Equals()), <, >, <=, >=, +, –, ++, --.Переопределить метод ToString() для 
вывода дроби. Определить операторы преобразования типов между типом дробь,float, int. Определить операторы *, /, %.
 */
namespace Lesson5
{
    public class RationalNumber
    {
        private int numerator; //числитель
        private int denominator; //знаменатель

        public int Numerator { get { return numerator; } set { numerator = value; } }
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (value != 0)
                {
                    denominator = value;
                }
                else
                {
                    throw new ArgumentException("Знаменатель не может равняться 0!");
                }
            }
        }

        /// <summary>
        /// Конструктор класса дробей.
        /// </summary>
        /// <param Числитель="numerator"></param>
        /// <param Знаменатель="denominator"></param>
        public RationalNumber(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        private RationalNumber()
        {

        }

        /// <summary>
        /// Возвращает строкое представление дроби. Выделяется целая часть.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            int integer = Numerator / Denominator;
            int tempNumerator = Numerator - integer * Denominator;

            return $"{integer}    {tempNumerator}/{denominator}";
        }

        /// <summary>
        /// Выполняет операцию сравнения с другой дробью.
        /// </summary>
        /// <param Дробь="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is RationalNumber number &&
                   Numerator * number.Denominator == number.Numerator * Denominator;
        }

        public override int GetHashCode()
        {
            return (numerator * denominator).GetHashCode();
        }

        //Метод по упрощению дроби. Используется алгоритм Евклида
        private void DivideByGreatestCommonDivisor()
        {
            int a = Numerator;
            int b = Denominator;

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            Numerator = Numerator / a;
            Denominator = Denominator / a;
        }

        static public bool operator ==(RationalNumber a, RationalNumber b)
        {
            if (a.Numerator * b.Denominator == a.Denominator * b.Numerator)
                return true;
            else
                return false;
        }

        static public bool operator !=(RationalNumber a, RationalNumber b)
        {
            if (a.Numerator * b.Denominator != a.Denominator * b.Numerator)
                return true;
            else
                return false;
        }

        static public RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            RationalNumber result = new RationalNumber();
            result.Numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            result.Denominator = a.denominator * b.denominator;
            result.DivideByGreatestCommonDivisor();
            return result;
        }

        static public RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            RationalNumber result = new RationalNumber();
            result.Numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            result.Denominator = a.denominator * b.denominator;
            result.DivideByGreatestCommonDivisor();
            return result;
        }

        static public RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            RationalNumber result = new RationalNumber();
            result.Numerator = a.Numerator * b.Numerator;
            result.Denominator = a.Denominator * b.Denominator;
            result.DivideByGreatestCommonDivisor();
            return result;
        }

        static public RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            RationalNumber result = new RationalNumber();
            result.Numerator = a.Numerator * b.Denominator;
            result.Denominator = a.Denominator * b.Numerator;
            result.DivideByGreatestCommonDivisor();
            return result;
        }

        static public RationalNumber operator ++(RationalNumber a)
        {
            RationalNumber result = new RationalNumber();
            result.Numerator = a.Numerator + a.Denominator;
            result.Denominator = a.Denominator;
            result.DivideByGreatestCommonDivisor();
            return result;
        }

        static public RationalNumber operator --(RationalNumber a)
        {
            RationalNumber result = new RationalNumber();
            result.Numerator = a.Numerator - a.Denominator;
            result.Denominator = a.Denominator;
            result.DivideByGreatestCommonDivisor();
            return result;
        }

        static public bool operator >(RationalNumber a, RationalNumber b)
        {
            if (a.Numerator * b.Denominator > b.Numerator * a.Denominator)
                return true;
            else
                return false;
        }

        static public bool operator <(RationalNumber a, RationalNumber b)
        {
            if (a.Numerator * b.Denominator < b.Numerator * a.Denominator)
                return true;
            else
                return false;
        }

        static public bool operator >=(RationalNumber a, RationalNumber b)
        {
            if (a.Numerator * b.Denominator >= b.Numerator * a.Denominator)
                return true;
            else
                return false;
        }

        static public bool operator <=(RationalNumber a, RationalNumber b)
        {
            if (a.Numerator * b.Denominator <= b.Numerator * a.Denominator)
                return true;
            else
                return false;
        }


        /// <summary>
        /// Явное приведение дроби к переменной типа int. Теряется часть данных
        /// </summary>
        /// <param Дробь="a"></param>
        static public explicit operator int(RationalNumber a)
        {
            return a.Numerator / a.Denominator;
        }

        /// <summary>
        /// Неявное преобразование дроби к переменной типа float. Данные не теряются.
        /// </summary>
        /// <param Дробь="a"></param>
        static public implicit operator float(RationalNumber a)
        {
            float result;
            result = (float)a.Numerator / (float)a.Denominator;
            return result;
        }
    }
}

