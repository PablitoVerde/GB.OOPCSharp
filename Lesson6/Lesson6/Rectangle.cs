using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class Rectangle : Point
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height, int coordinateX, int coordinateY, ConsoleColor consoleColor, bool isHeaden) : base(coordinateX, coordinateY, consoleColor, isHeaden)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public new string GetFigureInfo()
        {
            return base.GetFigureInfo() + $"Высота {Height}. Ширина {Width}.";
        }
    }
}
