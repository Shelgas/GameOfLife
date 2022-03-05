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

        public GameField()
        {
            Field = new Point[100, 20];
        }

        private void Draw()
        {

        }
    }
}
