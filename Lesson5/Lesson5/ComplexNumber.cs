using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
2. * На перегрузку операторов. Описать класс комплексных чисел. Реализовать операцию сложения, умножения, 
вычитания, проверку на равенство двух комплексных чисел. Переопределить метод ToString() для комплексного 
числа. Протестировать на простом примере.
*/

namespace Lesson5
{
    public class ComplexNumber
    {
        private double realPart;
        private double imaginaryPart;

        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }

        public ComplexNumber(double realPart, double imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }

        //Приватный конструктор для внутреннего использования классом (для методов при переопределении операторов)
        private ComplexNumber()
        {

        }

        /// <summary>
        /// Переопределенный метод приведения к строке
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str = string.Empty;
            if (ImaginaryPart < 0)
                str = $"{RealPart} {ImaginaryPart}*i";
            if (ImaginaryPart > 0)
                str = $"{RealPart} + {ImaginaryPart}*i";
            if (ImaginaryPart == 0)
                str = $"{RealPart}";
            return str;
        }

        static public ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber result = new ComplexNumber();
            result.RealPart = a.RealPart + b.RealPart;
            result.ImaginaryPart = a.ImaginaryPart + b.ImaginaryPart;
            return result;
        }

        static public ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber result = new ComplexNumber();
            result.RealPart = a.RealPart - b.RealPart;
            result.ImaginaryPart = a.ImaginaryPart - b.ImaginaryPart;
            return result;
        }

        static public ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber result = new ComplexNumber();
            result.RealPart = a.RealPart * b.RealPart - a.ImaginaryPart * b.ImaginaryPart;
            result.ImaginaryPart = a.ImaginaryPart * b.RealPart + a.RealPart * b.ImaginaryPart;
            return result;
        }

        static public ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber result = new ComplexNumber();
            result.RealPart = (a.RealPart * b.RealPart + a.ImaginaryPart * b.ImaginaryPart) / (b.RealPart * b.RealPart + b.ImaginaryPart * b.ImaginaryPart);
            result.ImaginaryPart = (a.ImaginaryPart * b.RealPart - a.RealPart * b.ImaginaryPart) / (b.RealPart * b.RealPart + b.ImaginaryPart * b.ImaginaryPart);
            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj is ComplexNumber number && this.RealPart == number.RealPart && this.ImaginaryPart == number.ImaginaryPart)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
