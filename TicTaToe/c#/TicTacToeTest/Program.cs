using System;
using System.Collections.Generic;
using TicTacToeEngine;

namespace TicTacToeTest
{
    internal class Program
    {
        private static TicTacToeGame game;

        private static void Main()
        {
            AfterTheGivenPlaysTheWinnerIs(FakePlaySeries.NoPlay, "No winner - Game in progress.");
            AfterPlayingTheGivenValueIsAtTheGivenPosition(FakePlaySeries.PlayOnceAtZeroZero, new Position(0, 0), "X");
            AfterPlayingTheGivenValueIsAtTheGivenPosition(FakePlaySeries.PlayTwiceSecondAtOneOne, new Position(1, 1), "O");
            AfterTheGivenPlaysTheWinnerIs(FakePlaySeries.XWinsWithThreeXsAtColumnZero, "X");
            AfterTheGivenPlaysTheWinnerIs(FakePlaySeries.OWinsWithThreeOsAtColumnOne, "O");
            AfterTheGivenPlaysTheWinnerIs(FakePlaySeries.XWinsWithThreeXsAtRowZero, "X");
            AfterTheGivenPlaysTheWinnerIs(FakePlaySeries.OWinsWithThreeOsAtRowTwo, "O");
            AfterTheGivenPlaysTheWinnerIs(FakePlaySeries.XWinsWithThreeXsAtFirstDiagonal, "X");
            AfterTheGivenPlaysTheWinnerIs(FakePlaySeries.XWinsWithThreeXsAtSecondDiagonal, "X");

            Console.ReadKey();
        }

        #region Tests

        private static void AfterPlayingTheGivenValueIsAtTheGivenPosition(List<Position> toBePlayed, Position position, string expectedValue)
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(toBePlayed);
            AreEqual(game.ValueAt(position), expectedValue);
        }

        private static void AfterTheGivenPlaysTheWinnerIs(List<Position> positionsToBePlayed, string theWinner)
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(positionsToBePlayed);
            AreEqual(game.Winner, theWinner);
        }

        #endregion

        #region Glue code

        private static void PlayTheGivenPositions(List<Position> positions)
        {
            positions.ForEach(p => game.PlayAt(p));
        }

        private static void CreateEmptyTicTacToeGame()
        {
            game = new TicTacToeGame();
        }
        #endregion

        #region asserts

        private static void AreEqual(string actual, string expected)
        {
            string message = "Expected value was " + expected + ", actual value was " + actual;
            var prefix = actual == expected ? "Succes: " : "Failure: ";
            Console.WriteLine(prefix + message);
        }

        #endregion
    }
}