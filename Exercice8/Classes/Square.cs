using Exercice8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8.Classes
{
    internal class Square : Figure
    {
        public double Side { get; set; }
        public Point B => new Point(A.X + Side, A.Y);
        public Point C => new Point(A.X + Side, A.Y - Side);
        public Point D => new Point(A.X, A.Y - Side);

        public Square(Point a, double side) : base(a)
        {
            Side = side;
        }

        public Square(double x, double y, double side) : base(x,y)
        {
            Side = side;
        }

        public override string ToString()
        {
            return $"Coordinates of Square ABCD (Side = {Side})" +
                $"\nA = {A}" +
                $"\nB = {B}" +
                $"\nC = {C}" +
                $"\nD = {D}";
        }
    }
}
