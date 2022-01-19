using System;
using System.IO;

/*
 * 3. * Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail адрес. Разделителем между ФИО и адресом электронной почты является символ &: 
 * Кучма Андрей Витальевич & Kuchma@mail.ru Мизинцев Павел Николаевич & Pasha@mail.ru Сформировать новый файл, содержащий список адресов электронной почты. 
 * Предусмотреть метод, выделяющий из строки адрес почты. Методу в качестве параметра передается символьная строка s, e-mail возвращается в той же строке s: 
 * public void SearchMail (ref string s).
 * */

namespace Lesson3_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Имена и адреса");

            string path = Directory.GetCurrentDirectory() + @"\FIO.txt";

            GetEmails(path);
        }

        static void GetEmails(string path)
        {
            //путь для записи списка адресов
            string path2 = Directory.GetCurrentDirectory() + @"\emails.txt";

            // проверка пути с именами и адресами
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл с данными не найдем", path);

            //чтение файла построчно и запись в другой файл
            FileStream fs1 = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs1);

            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                SearchMail(ref line);
                File.AppendAllText(path2, line + Environment.NewLine);
            }
        }

        static void SearchMail(ref string s)
        {
            s = s.Trim();
            s.IndexOf('&');
            s = s.Substring(s.IndexOf('&'));
            s = s.Remove(0, 1);
            s = s.Trim();
        }
    }
}
