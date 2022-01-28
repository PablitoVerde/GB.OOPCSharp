using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class Point : Figure
    {
        private int coordinateX;
        private int coordinateY;

        public Point(int coordinateX, int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }

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
                    CoordinateY = value;
                else
                    throw new Exception("Неверная координата");
            }
        }

        public override void MoveHorizontal(int x)
        {
            CoordinateX = CoordinateX + x;
        }

        public override void MoveVertical(int y)
        {
            CoordinateY = CoordinateY + y;
        }
    }
}
