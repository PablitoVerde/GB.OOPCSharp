using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    abstract class Figure
    {
        private ConsoleColor color;
        private bool isHeaden;


        private ConsoleColor Color { get { return color; } set { color = value; } }
        private bool IsHeaden { get { return isHeaden; } set { isHeaden = value; } }



        public abstract void MoveHorizontal(int x);
        public abstract void MoveVertical(int y);


        public bool CheckIsHeaden()
        {
            return IsHeaden;
        }

        public void ChangeColor(ConsoleColor consoleColor)
        {
            Color = consoleColor;
        }

        public void PrintFigureInfo()
        {
            Console.WriteLine($"Цвет: {Color}. Скрыт: {IsHeaden}.");
        }
    }
}
