namespace GameOfLife
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.SetWindowSize(120, 40);
            Console.CursorVisible = false;

            var initCells = new List<Point>()
            {
                new Point(2, 6, '▓'),
                new Point(2, 7, '▓'),
                new Point(3, 6, '▓'),
                new Point(3, 7, '▓'),
                new Point(12, 6, '▓'),
                new Point(12, 7, '▓'),
                new Point(12, 8, '▓'),
                new Point(13, 5, '▓'),
                new Point(13, 9, '▓'),
                new Point(14, 4, '▓'),
                new Point(14, 10, '▓'),
                new Point(15, 4, '▓'),
                new Point(15, 10, '▓'),
                new Point(16, 7, '▓'),
                new Point(17, 5, '▓'),
                new Point(17, 9, '▓'),
                new Point(18, 6, '▓'),
                new Point(18, 7, '▓'),
                new Point(18, 8, '▓'),
                new Point(19, 7, '▓'),
                new Point(22, 4, '▓'),
                new Point(22, 5, '▓'),
                new Point(22, 6, '▓'),
                new Point(23, 4, '▓'),
                new Point(23, 5, '▓'),
                new Point(23, 6, '▓'),
                new Point(24, 3, '▓'),
                new Point(24, 7, '▓'),
                new Point(26, 3, '▓'),
                new Point(26, 7, '▓'),
                new Point(26, 2, '▓'),
                new Point(26, 8, '▓'),
                new Point(36, 4, '▓'),
                new Point(36, 5, '▓'),
                new Point(37, 4, '▓'),
                new Point(37, 5, '▓')
            }; 

            var gameField = new GameField(100, 40, initCells);
            gameField.Draw();
            while (true)
            {
                gameField.DrawNextGen();
            }
        }
    }

}