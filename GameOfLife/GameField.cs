using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class GameField
    {

        public Point[,] Field { get; private set; }
        public readonly int Height;
        public readonly int Width;

        public GameField(int width, int height)
        {
            Width = width;
            Height = height;
            Field = new Point[width, height];
            InitGameField();
        }

        private void InitGameField()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    if (x == 0 && y == 0) Field[x, y] = new Point(x, y, '╔');
                    else if (x == Width - 1 && y == 0) Field[x, y] = new Point(x, y, '╗');
                    else if (x == Width - 1 && y == Height - 1) Field[x, y] = new Point(x, y, '╝');
                    else if (x == 0 && y == Height - 1) Field[x, y] = new Point(x, y, '╚');
                    else if (y == 0 || y == Height - 1) Field[x, y] = new Point(x, y, '═');
                    else if (x == 0 || x == Width - 1) Field[x, y] = new Point(x, y, '║');
                }
            }
        }

        public void Draw()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Field[x, y].Draw();
                }
            }
        }

    }
}
