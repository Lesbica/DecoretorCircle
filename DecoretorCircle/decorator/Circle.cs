using System;
using System.Drawing;

namespace DecoretorCircle.decorator
{
    abstract class Circle
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public abstract void DisplayInConsole();

        public abstract void DisplayOnForm(Graphics g, Pen p, int x, int y);
    }
}
