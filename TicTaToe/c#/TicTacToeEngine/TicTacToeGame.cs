namespace TicTacToeEngine
{
    public class TicTacToeGame
    {
        private readonly string[,] board = new string[3, 3];

        private readonly string NoWinner = "No winner - Game in progress.";

        private string actualPlayer = string.Empty;

        public TicTacToeGame()
        {
            Winner = NoWinner;
        }

        public string Winner { get; private set; }

        public void PlayNextTurnAt(Position newPosition)
        {
            DecideWhoIsPlaying();
            SetThePosition(newPosition);
            if (ActualPlayerHasWonAfterPlayingAt(newPosition))
            {
                SetTheWinner();
            }
        }

        private void SetTheWinner()
        {
            Winner = actualPlayer;
        }

        private void SetThePosition(Position newPosition)
        {
            board[newPosition.X, newPosition.Y] = actualPlayer;
        }

        private void DecideWhoIsPlaying()
        {
            actualPlayer = actualPlayer == "X" ? "O" : "X";
        }

        private bool ActualPlayerHasWonAfterPlayingAt(Position theLastPlayPosition) => 
            IsVerticalWinnerAtColumn(theLastPlayPosition.X) || IsHorizontalWinnerAtRow(theLastPlayPosition.Y) || 
            IsFirstDiagonalWinner() || IsSecondDiagonalWinner();

        private bool IsSecondDiagonalWinner()
            => (ValueAt(0, 2) == actualPlayer && ValueAt(1, 1) == actualPlayer && ValueAt(2, 0) == actualPlayer);

        private bool IsFirstDiagonalWinner()
            => (ValueAt(0, 0) == actualPlayer && ValueAt(1, 1) == actualPlayer && ValueAt(2, 2) == actualPlayer);

        private bool IsHorizontalWinnerAtRow(int y)
            => ValueAt(0, y) == actualPlayer && ValueAt(1, y) == actualPlayer && ValueAt(2, y) == actualPlayer;

        private bool IsVerticalWinnerAtColumn(int x)
            => ValueAt(x, 0) == actualPlayer && ValueAt(x, 1) == actualPlayer && ValueAt(x, 2) == actualPlayer;

        public string ValueAt(Position p) => ValueAt(p.X, p.Y);

        private string ValueAt(int x, int y) => board[x, y];
    }
}