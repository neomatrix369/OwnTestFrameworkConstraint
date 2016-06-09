namespace TicTacToeTest
{
    public class Position
    {
        public Position(int x, int y)
        {
            Y = y;
            X = x;
        }

        public int X { get; private set; }

        public int Y { get; private set; }
    }
}