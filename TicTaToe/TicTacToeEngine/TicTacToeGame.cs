namespace TicTacToeEngine
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

        public void PlayAt(Position newPosition)
        {
            actualValue = actualValue == "X" ? "O" : "X";
            board[newPosition.X, newPosition.Y] = actualValue;
            SetWinner(newPosition);
        }

        private void SetWinner(Position p)
        {
            if (IsVerticalWinnerAtColumn(p.X) || 
                IsHorizontalWinnerAtRow(p.Y) ||
                IsFirstDiagonalWinner() ||
                IsSecondDiagonalWinner())
            {
                Winner = actualValue;
            }
        }

        private bool IsSecondDiagonalWinner() => (ValueAt(0, 2) == actualValue
                                                 && ValueAt(1, 1) == actualValue
                                                 && ValueAt(2, 0) == actualValue);

        private bool IsFirstDiagonalWinner() => (ValueAt(0, 0) == actualValue
                                                 && ValueAt(1, 1) == actualValue
                                                 && ValueAt(2, 2) == actualValue);

        private bool IsHorizontalWinnerAtRow(int y) => ValueAt(0, y) == actualValue
                                                       && ValueAt(1, y) == actualValue
                                                       && ValueAt(2, y) == actualValue;

        private bool IsVerticalWinnerAtColumn(int x) => ValueAt(x, 0) == actualValue &&
                                                        ValueAt(x, 1) == actualValue &&
                                                        ValueAt(x, 2) == actualValue;

        public string ValueAt(Position p) => ValueAt(p.X, p.Y);

        private string ValueAt(int x, int y) => board[x, y];
    }
}