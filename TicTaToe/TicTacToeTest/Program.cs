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
            ThereIsNoWinnerAsTheGameBegins();
            AfterFirstTurnPlayedAtZeroZero_ThereIsAnXAtpositionZeroZero();
            AfterSecondTurnPlayedAtOneOne_ThereIsAnOAtPositionOneOne();
            XWinsIfThreeVerticalXsAreFoundAtColumnZero();
            OWinsIfThreeVerticalOsAreFoundAtColumnOne();
            XWinsIfThreeHorizontalXsAreFoundAtRowZero();
            OWinsIfThreeHorizontalOsAreFoundAtRowTwo();
            XWinsIfThereIsThreeXsInTheFirstDiagonal();
            XWinsIfThereIsThreeXsInTheSecondDiagonal();

            Console.ReadKey();
        }

        #region Tests
        private static void ThereIsNoWinnerAsTheGameBegins()
        {
            CreateEmptyTicTacToeGame();
            AreEqual(game.Winner, "No winner - Game in progress.");
        }

        private static void AfterFirstTurnPlayedAtZeroZero_ThereIsAnXAtpositionZeroZero()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(FakePlaySeries.PlayOnceAtZeroZero);
            AreEqual(game.ValueAt(new Position(0, 0)), "X");
        }

        private static void AfterSecondTurnPlayedAtOneOne_ThereIsAnOAtPositionOneOne()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(FakePlaySeries.PlayTwiceSecondAtOneOne);
            AreEqual(game.ValueAt(new Position(1,1)), "O");
        }

        private static void XWinsIfThreeVerticalXsAreFoundAtColumnZero()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(FakePlaySeries.XWinsWithThreeXsAtColumnZero);
            AreEqual(game.Winner, "X");
        }

        private static void OWinsIfThreeVerticalOsAreFoundAtColumnOne()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(FakePlaySeries.OWinsWithThreeOsAtColumnOne);
            AreEqual(game.Winner, "O");
        }

        private static void XWinsIfThreeHorizontalXsAreFoundAtRowZero()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(FakePlaySeries.XWinsWithThreeXsAtRowZero);
            AreEqual(game.Winner, "X");
        }

        private static void OWinsIfThreeHorizontalOsAreFoundAtRowTwo()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(FakePlaySeries.OWinsWithThreeOsAtRowTwo);
            AreEqual(game.Winner, "O");
        }

        private static void XWinsIfThereIsThreeXsInTheFirstDiagonal()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(FakePlaySeries.XWinsWithThreeXsAtFirstDiagonal);
            AreEqual(game.Winner, "X");
        }

        private static void XWinsIfThereIsThreeXsInTheSecondDiagonal()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(FakePlaySeries.XWinsWithThreeXsAtSecondDiagonal);
            AreEqual(game.Winner, "X");
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