using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 2. * Создать класс Figure для работы с геометрическими фигурами. В качестве полей класса задаются цвет фигуры, состояние 
 * «видимое/невидимое». Реализовать операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение 
 * цвета, опрос состояния (видимый/невидимый). Метод вывода на экран должен выводить состояние всех полей объекта. Создать 
 * класс Point (точка) как потомок геометрической фигуры. Создать класс Circle (окружность) как потомок точки. В класс Circle 
 * добавить метод, который вычисляет площадь окружности. Создать класс Rectangle (прямоугольник) как потомок точки, реализовать 
 * метод вычисления площади прямоугольника. Точка, окружность, прямоугольник должны поддерживать методы передвижения по 
 * горизонтали и вертикали, изменения цвета.
 * */

namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(5, 5, ConsoleColor.Green, true);
            Console.WriteLine(p.GetFigureInfo());

            Circle circle = new Circle(4, 8, 14, ConsoleColor.Blue, false);
            Console.WriteLine(circle.GetFigureInfo());

            Rectangle rectangle = new Rectangle(8, 9, 4, 3, ConsoleColor.Yellow, false);
            Console.Write(rectangle.GetFigureInfo());

            circle.ChangeColor(ConsoleColor.Red);
            Console.WriteLine(circle.GetFigureInfo());

            rectangle.ChangeColor(ConsoleColor.Green);
            Console.WriteLine(rectangle.GetFigureInfo());

            circle.MoveHorizontal(25);
            circle.MoveVertical(25);
            Console.WriteLine(circle.GetFigureInfo());

            rectangle.MoveHorizontal(30);
            rectangle.MoveVertical(30);
            Console.WriteLine(rectangle.GetFigureInfo());

            Console.WriteLine(circle.GetArea());
            Console.WriteLine(rectangle.GetArea());

            Console.ReadKey();

        }
    }
}
