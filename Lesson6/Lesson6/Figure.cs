using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    abstract public class Figure
    {
        private ConsoleColor color;
        private bool isHeaden;


        public ConsoleColor Color { get { return color; } set { color = value; } }
        public bool IsHeaden { get { return isHeaden; } set { isHeaden = value; } }

        //Абстрактные методы перемещения фигуры
        public abstract void MoveHorizontal(int x);
        public abstract void MoveVertical(int y);

        /// <summary>
        /// Конструктор базового класса фигура
        /// </summary>
        /// <param Цвет="consoleColor"></param>
        /// <param Скрыт или не скрыт="isHeaden"></param>
        protected Figure(ConsoleColor consoleColor, bool isHeaden)
        {
            Color = consoleColor;
            IsHeaden = isHeaden;
        }

        /// <summary>
        /// Проверка скрытости или нескрытости фигуры
        /// </summary>
        /// <returns></returns>
        public bool CheckIsHeaden()
        {
            return IsHeaden;
        }

        /// <summary>
        /// Изменяет цвет фигуры
        /// </summary>
        /// <param name="consoleColor"></param>
        public void ChangeColor(ConsoleColor consoleColor)
        {
            Color = consoleColor;
        }

        /// <summary>
        /// Получение информации о фигуре
        /// </summary>
        /// <returns></returns>
        protected string GetFigureInfo()
        {
            return $"Объект {GetType()}. Цвет: {Color}. Скрыт: {IsHeaden}.";
        }
    }
}
