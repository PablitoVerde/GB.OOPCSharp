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

        public Circle(double radius, Point point)
        {
            Radius = radius;
            CoordinateX = point.CoordinateX;
            CoordinateY = point.CoordinateY;
        }

        public double Area()
        {
            return Radius * Radius * Math.PI;
        }

    }
}
