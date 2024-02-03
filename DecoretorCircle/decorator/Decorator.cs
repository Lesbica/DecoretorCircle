using System;
using System.Drawing;

namespace DecoretorCircle.decorator
{
    abstract class Decorator : Circle
    {
        protected Circle circle;

        public Decorator(Circle circle) : base(circle.radius)
        {
            this.circle = circle;
        }

        public override void DisplayInConsole()
        {
            circle.DisplayInConsole();
        }

        public override void DisplayOnForm(Graphics g, Pen p, int x, int y)
        {
            circle.DisplayOnForm(g, p, x, y);
        }
    }
}
