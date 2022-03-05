using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal struct Point
    {
        public readonly int X;
        public readonly int Y;
        public const char Symbol = ' ';

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }
    }
}
