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
            var count = 0;
            for (var actualY = 0; actualY < 3; actualY++)
            {
                if (board[p.X, actualY] == actualValue)
                {
                    count++;
                }
            }
            if (count == 3)
            {
                Winner = actualValue;
            }
        }

        public string ValueAt(Position p) => board[p.X, p.Y];
    }
}