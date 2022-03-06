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
                new Point(1, 1, '▓'),
                new Point(1, 2, '▓'),
                new Point(1, 3, '▓')
            }; 

            var gameField = new GameField(100, 20, initCells);
            gameField.Draw();
            gameField.DrawNextGen();
            gameField.DrawNextGen();
        }
    }

}