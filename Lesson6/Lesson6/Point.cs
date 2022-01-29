using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Point : Figure
    {
        private int coordinateX;
        private int coordinateY;

        public Point(int coordinateX, int coordinateY, ConsoleColor consoleColor, bool isHeaden) : base(consoleColor, isHeaden)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }

        //Свойства класса. Имеется проверка на выход при перемещении объекта за границы поля
        public int CoordinateX
        {
            get
            {
                return coordinateX;
            }
            set
            {
                if (coordinateX + value >= 0)
                    coordinateX = value;
                else
                    throw new Exception("Неверная координата");
            }
        }
        public int CoordinateY
        {
            get
            {
                return coordinateY;
            }
            set
            {
                if (CoordinateY + value >= 0)
                    coordinateY = value;
                else
                    throw new Exception("Неверная координата");
            }
        }

        //Переопределение методов по перемещению фигуры
        public override void MoveHorizontal(int x)
        {
            CoordinateX = CoordinateX + x;
        }

        public override void MoveVertical(int y)
        {
            CoordinateY = CoordinateY + y;
        }

        public virtual double GetArea()
        {
            return 0;
        }

        //Скрытие метода базового класса при сохранении возможности получить информацию из него
        public new string GetFigureInfo()
        {
            return base.GetFigureInfo() + $"Координата Х {CoordinateX}. Координата Y {CoordinateY}.";
        }
    }
}
