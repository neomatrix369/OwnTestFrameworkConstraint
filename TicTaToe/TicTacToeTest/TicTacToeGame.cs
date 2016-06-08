namespace TicTacToeTest
{
    public class TicTacToeGame
    {
        public TicTacToeGame()
        {
            Winner = NoWinner;
        }
        private readonly string[,] board = new string[3, 3];

        private string actualValue = string.Empty;

        private string NoWinner = "No winner - Game in progress.";
        public string Winner { get; private set; }
        public string ValueAt(int x, int y) => board[x, y];

        public void PlayAt(int x, int y)
        {
            actualValue = actualValue == "X" ? "O" : "X";
            board[x, y] = actualValue;
            var count = 0;
            for (var actualY = 0; actualY < 3; actualY++)
            {
                if (board[x, actualY] == actualValue)
                    count++;
            }
            if (count == 3)
                Winner = actualValue;
        }
    }
}