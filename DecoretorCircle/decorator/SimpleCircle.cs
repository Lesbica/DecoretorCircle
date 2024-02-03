using System;
using System.Drawing;

namespace DecoretorCircle.decorator
{
    class SimpleCircle : Circle
    {
        public SimpleCircle(double radius) : base(radius) { }

        public override void DisplayInConsole()
        {
            Console.WriteLine("Simple circle with radius {0}", radius);
            char symbol = '*';

            int diameter = (int)Math.Ceiling(radius * 2);

            char[,] circle = new char[diameter, diameter];

            for (int i = 0; i < diameter; i++)
            {
                for (int j = 0; j < diameter; j++)
                {
                    circle[i, j] = ' ';
                }
            }

            int x = (int)radius - 1;
            int y = 0;
            int dx = 1;
            int dy = 1;
            int err = dx - (int)diameter;
            while (x >= y)
            {
                circle[(int)radius + x - 1, (int)radius + y - 1] = symbol;
                circle[(int)radius + y - 1, (int)radius + x - 1] = symbol;
                circle[(int)radius - y - 1, (int)radius + x - 1] = symbol;
                circle[(int)radius - x - 1, (int)radius + y - 1] = symbol;
                circle[(int)radius - x - 1, (int)radius - y - 1] = symbol;
                circle[(int)radius - y - 1, (int)radius - x - 1] = symbol;
                circle[(int)radius + y - 1, (int)radius - x - 1] = symbol;
                circle[(int)radius + x - 1, (int)radius - y - 1] = symbol;
                if (err <= 0)
                {
                    y++;
                    err += dy;
                    dy += 2;
                }
                if (err > 0)
                {
                    x--;
                    dx += 2;
                    err += dx - (int)diameter;
                }
            }

            for (int i = 0; i < diameter; i++)
            {
                for (int j = 0; j < diameter; j++)
                {
                    Console.Write(circle[i, j]);
                }
                Console.WriteLine();
            }
        }

        public override void DisplayOnForm(Graphics g, Pen p, int x, int y)
        {
            g.DrawEllipse(p, x - (int)radius, y - (int)radius, (int)radius * 2, (int)radius * 2);
        }
    }
}
