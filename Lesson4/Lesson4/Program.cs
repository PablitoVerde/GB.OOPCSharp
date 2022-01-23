using System;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Building b = new Building(50, 5, 60, 3);
            Console.WriteLine($"ID {b.Id}. Высота {b.Height}. Этажи {b.FloorCount}. Квартиры {b.FlatCount}.  Подъезды {b.EntranceCount}");
            Console.WriteLine($"Квартиры в подъезде {b.flatOnBlock()}. Квартир на этаже {b.flatOnFloor()}. Высота потолка {b.floorHeight()}");

            Console.ReadKey();
        }
    }
}
