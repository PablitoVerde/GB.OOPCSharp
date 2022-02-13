using System;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Пример работы класса рациональных чисел
            Console.WriteLine("Рациональные числа");

            RationalNumber a = new RationalNumber(6, 5);
            RationalNumber b = new RationalNumber(3, 7);

            RationalNumber c = a + b;
            c = a - b;
            c = a * b;
            c = a / b;

            int d = ((int)c);
            float f = c;

            Console.WriteLine(c.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(f.ToString());

            /// Пример работы класса комплексных чисел
            Console.WriteLine("Комплексные числа");

            ComplexNumber number = new ComplexNumber(3, -8);
            ComplexNumber number1 = new ComplexNumber(5, +3);

            ComplexNumber h = number + number1;
            Console.WriteLine(h.ToString());

            h = number - number1;
            Console.WriteLine(h.ToString());

            h = number * number1;
            Console.WriteLine(h.ToString());

            h = number / number1;
            Console.WriteLine(h.ToString());

            Console.ReadKey();
        }
    }
}
