namespace TicTacToeTest
{
    public class TicTacToeGame
    {
        private readonly string[,] board = new string[3, 3];

        private string actualValue = string.Empty;

        public string Winner => "No winner - Game in progress.";

        public string ValueAt(int x, int y)
        {
            return board[x, y];
        }

        public void playAt(int x, int y)
        {
            actualValue = actualValue == "X" ? "O" : "X";
            board[x, y] = actualValue;
        }
    }
}