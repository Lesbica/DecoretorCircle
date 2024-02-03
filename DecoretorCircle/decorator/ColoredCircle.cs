using System;
using System.Drawing;

namespace DecoretorCircle.decorator
{
    class ColoredCircle : Decorator
    {
        private Color color;

        public ColoredCircle(Circle circle, Color color) : base(circle)
        {
            this.color = color;
        }

        public override void DisplayInConsole()
        {
            base.DisplayInConsole();
            Console.WriteLine("Color: {0}", color);
        }

        public override void DisplayOnForm(Graphics g, Pen p, int x, int y)
        {
            p.Color = color;
            base.DisplayOnForm(g, p, x, y);
        }
    }
}
