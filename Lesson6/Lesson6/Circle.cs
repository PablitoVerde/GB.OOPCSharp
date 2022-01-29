using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class Circle : Point
    {
        private double radius;

        public double Radius { get { return radius; } set { radius = value; } }

        public Circle(double radius, int coordinateX, int coordinateY, ConsoleColor consoleColor, bool isHeaden) : base(coordinateX, coordinateY, consoleColor, isHeaden)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }

        public new string GetFigureInfo()
        {
            return base.GetFigureInfo() + $"Радиус {Radius}.";
        }
    }
}
