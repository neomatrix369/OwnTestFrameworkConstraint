using System;

namespace TicTacToeTest
{
    internal class Program
    {
        private static TicTacToeGame game;

        private static void Main(string[] args)
        {
            ThereIsNoWinnerAsLongAsTheGameIsInProcess();

            AfterFirstTurnPlayedAtZeroZero_AnXCanBeFountAtThisPosition();

            AfterSecondTurnPlayedAtOneOne_ThereIsAnOAtPositionOneOne();


            Console.ReadKey();
        }

        private static void AfterSecondTurnPlayedAtOneOne_ThereIsAnOAtPositionOneOne()
        {
            CreateTicTacToeGame();
            game.playAt(0, 0);
            game.playAt(1, 1);
            CheckPositionForValue(1, 1, "O");
        }

        private static void CheckPositionForValue(int x, int y, string expectedValue)
        {
            if (game.ValueAt(x, y) == expectedValue)
            {
                Console.WriteLine("Success: Value at " + x + ", " + y + " is " + expectedValue + " as expected.");
            }
            else
            {
                Console.WriteLine("Failure: Expected value at " + x + ", " + y + " was " + expectedValue + ", but found " +
                                  game.ValueAt(x, y));
            }
        }

        private static void CreateTicTacToeGame()
        {
            game = new TicTacToeGame();
        }

        private static void AfterFirstTurnPlayedAtZeroZero_AnXCanBeFountAtThisPosition()
        {
            var expectedValue = "X";
            CreateTicTacToeGame();
            game.playAt(0, 0);

            if (game.ValueAt(0, 0) == expectedValue)
            {
                Console.WriteLine("Success: Value at 0, 0 is " + expectedValue + " as expected.");
            }
            else
            {
                Console.WriteLine("Failure: Expected value at 0, 0 was " + expectedValue + ", but found " +
                                  game.ValueAt(0, 0));
            }
        }

        private static void ThereIsNoWinnerAsLongAsTheGameIsInProcess()
        {
            var expectedWinner = "No winner - Game in progress.";
            CreateTicTacToeGame();
            if (game.Winner == expectedWinner)
            {
                Console.WriteLine("Success: Winner is " + expectedWinner);
            }
            else
            {
                Console.WriteLine("Failure: Expected winner was " + expectedWinner + ", but winner is " + game.Winner);
            }
        }
    }
}