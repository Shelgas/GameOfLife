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
        public List<Point> Cells { get; set; }

        public GameField(int width, int height, List<Point> cells)
        {
            Width = width;
            Height = height;
            Field = new Point[width, height];
            Cells = cells;
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
                    else if (Cells.Any(c => c.X == x && c.Y == y)) Field[x, y] = new Point(x, y, '▓');
                    else Field[x, y] = new Point(x, y);
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

        public void DrawNextGen()
        {
            Point[,] newField = new Point[Width, Height];
            
            for (int x = 1; x < Width - 1; x++)
            {
                for (int y = 1; y < Height - 1; y++)    
                {
                    newField[x, y] = CheckNewCell(Field[x, y]);
                }
            }

            for (int x = 1; x < Width - 1; x++)
            {
                for (int y = 1; y < Height - 1; y++)
                {
                    Field[x, y] = newField[x, y];
                }
            }

            Draw();
        }


        private Point CheckNewCell(Point oldPoint)
        {
            var cellsCount = 0;

            for (int x = oldPoint.X - 1; x < oldPoint.X + 2; x++)
            {
                for (int y = oldPoint.Y - 1; y < oldPoint.Y + 2; y++)
                {

                    var xRealCoordinate = x;
                    var yRealCoordinate = y;

                    if (xRealCoordinate == 0) xRealCoordinate = Width - 2;
                    if (yRealCoordinate == 0) yRealCoordinate = Height - 2;
                    if (xRealCoordinate == Width - 1) xRealCoordinate = 1;
                    if (yRealCoordinate == Height - 1) yRealCoordinate = 1;

                    if (Field[xRealCoordinate,yRealCoordinate].Symbol == '▓') cellsCount++;
                    if (cellsCount == 3) 
                        return new Point(oldPoint.X,oldPoint.Y, '▓');
                }
            }
            return new Point(oldPoint.X, oldPoint.Y, ' ');
        }

    }
}
