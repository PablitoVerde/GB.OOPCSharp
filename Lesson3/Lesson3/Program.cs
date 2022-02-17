using System;
using System.Text;

/*
 * 2. Реализовать метод, который в качестве входного параметра принимает строку string, возвращает строку типа string, буквы в которой идут в обратном порядке. Протестировать метод.
 * */
namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Все задом наперед!");

            Console.WriteLine("Введите строку: ");

            string str = Console.ReadLine();

            Console.WriteLine(MakeRevert(str));

            Console.ReadKey();
        }

        /// <summary>
        /// Метод, принимающий строку в формате string. Возвращает string, где символы идут в обратном порядке
        /// </summary>
        /// <param Строка="s"></param>
        /// <returns></returns>
        static string MakeRevert(string s)
        {           
            StringBuilder sb = new StringBuilder();
            char[] chars = s.ToCharArray();

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                sb.Append(chars[i]);
            }

            return sb.ToString();
        }

    }
}
