using Exercice8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8.Classes
{
    internal abstract class Figure : IMoveable
    {
        public Point A { get; } // origine

        protected Figure(Point origin)
        {
            A = origin;
        }
        protected Figure(double x, double y)
        {
            A = new Point(x, y);
        }

        public void Move(double x, double y)
        {
            A.X += x;
            A.Y += y;
        }
    }
}
