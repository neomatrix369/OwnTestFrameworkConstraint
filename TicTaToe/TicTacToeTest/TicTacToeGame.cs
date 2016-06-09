using System;

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

        public void PlayAt(Position newPosition)
        {
            actualValue = actualValue == "X" ? "O" : "X";
            board[newPosition.X, newPosition.Y] = actualValue;
            SetWinner(newPosition);
        }

        private void SetWinner(Position p)
        {
            if (IsVerticalWinnerAtColumn(p.X) ||
                (ValueAt(0, 0) == actualValue
                && ValueAt(1, 0) == actualValue
                && ValueAt(2, 0) == actualValue
                ))
            {
                Winner = actualValue;
            }
        }

        private bool IsVerticalWinnerAtColumn(int x) => ValueAt(x, 0) == actualValue &&
                                                        ValueAt(x, 1) == actualValue &&
                                                        ValueAt(x, 2) == actualValue;

        public string ValueAt(Position p) => ValueAt(p.X, p.Y);

        private string ValueAt(int x, int y) => board[x, y];
    }
}