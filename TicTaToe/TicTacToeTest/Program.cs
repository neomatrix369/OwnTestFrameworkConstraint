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
            var expectedValue = "O";
            CreateTicTacToeGame();
            game.playAt(0, 0);
            game.playAt(1, 1);

            if (game.ValueAt(1, 1) == expectedValue)
            {
                Console.WriteLine("Success: Value at 1, 1 is " + expectedValue + " as expected.");
            }
            else
            {
                Console.WriteLine("Failure: Expected value at 1, 1 was " + expectedValue + ", but found " +
                                  game.ValueAt(0, 0));
            }
        }

        private static void CreateTicTacToeGame()
        {
            game = new TicTacToeGame();
        }

        private static void AfterFirstTurnPlayedAtZeroZero_AnXCanBeFountAtThisPosition()
        {
            var expectedValue = "X";
            var game = new TicTacToeGame();
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
            var game = new TicTacToeGame();
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