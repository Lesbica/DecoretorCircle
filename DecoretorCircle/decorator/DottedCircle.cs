using System;
using System.Drawing;

namespace DecoretorCircle.decorator
{
    class DottedCircle : Decorator
    {
        private float dotSize;

        public DottedCircle(Circle circle, float dotSize) : base(circle)
        {
            this.dotSize = dotSize;
        }

        public override void DisplayInConsole()
        {
            base.DisplayInConsole();
            Console.WriteLine("Dot size: {0}", dotSize);
        }

        public override void DisplayOnForm(Graphics g, Pen p, int x, int y)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            p.Width = dotSize;
            base.DisplayOnForm(g, p, x, y);
        }
    }
}
