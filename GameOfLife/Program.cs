namespace GameOfLife
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.SetWindowSize(120, 40);
            Console.CursorVisible = false;

            var gameField = new GameField(100, 20);
            gameField.Draw();
        }
    }

}