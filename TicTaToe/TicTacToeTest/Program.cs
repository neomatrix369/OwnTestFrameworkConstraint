using System;
using System.CodeDom;
using System.Collections.Generic;

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
            PlayTheGivenPositions(PlayOnceAtZeroZero);
            AreEqual(game.ValueAt(new Position(0, 0)), "X");
        }

        private static void AfterSecondTurnPlayedAtOneOne_ThereIsAnOAtPositionOneOne()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(PlayTwiceSecondAtOneOne);
            AreEqual(game.ValueAt(new Position(1,1)), "O");
        }

        private static void XWinsIfThreeVerticalXsAreFoundAtColumnZero()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(XWinsWithThreeXsAtColumnZero);
            AreEqual(game.Winner, "X");
        }

        private static void OWinsIfThreeVerticalOsAreFoundAtColumnOne()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(OWinsWithThreeOsAtColumnOne);
            AreEqual(game.Winner, "O");
        }

        private static void XWinsIfThreeHorizontalXsAreFoundAtRowZero()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(XWinsWithThreeXsAtRowZero);
            AreEqual(game.Winner, "X");
        }

        private static void OWinsIfThreeHorizontalOsAreFoundAtRowTwo()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(OWinsWithThreeOsAtRowTwo);
            AreEqual(game.Winner, "O");
        }

        private static void XWinsIfThereIsThreeXsInTheFirstDiagonal()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(XWinsWithThreeXsAtFirstDiagonal);
            AreEqual(game.Winner, "X");
        }

        private static void XWinsIfThereIsThreeXsInTheSecondDiagonal()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(XWinsWithThreeXsAtSecondDiagonal);
            AreEqual(game.Winner, "X");
        }

        #endregion

        #region Glue code
        private static List<Position> XWinsWithThreeXsAtColumnZero =>
            new List<Position>
                {new Position(0, 0), new Position(1, 0), new Position(0, 1),
                new Position(1, 1), new Position(0, 2)};
        private static List<Position> XWinsWithThreeXsAtRowZero =>
            new List<Position>
                {new Position(0, 0), new Position(1,2), new Position(1, 0),
                new Position(1, 1), new Position(2, 0)};
        private static List<Position> XWinsWithThreeXsAtFirstDiagonal =>
            new List<Position>
                {new Position(0, 0), new Position(1,2), new Position(1, 1),
                new Position(1, 0), new Position(2, 2)};
        private static List<Position> XWinsWithThreeXsAtSecondDiagonal =>
            new List<Position>
                {new Position(0, 2), new Position(1,2), new Position(1, 1),
                new Position(1, 0), new Position(2, 0)};
        private static List<Position> OWinsWithThreeOsAtColumnOne =>
            new List<Position>
                {new Position(0, 0), new Position(1, 0), new Position(0, 1),
                new Position(1, 1), new Position(2, 0), new Position(1, 2)};
        private static List<Position> OWinsWithThreeOsAtRowTwo =>
            new List<Position>
                {new Position(0, 0), new Position(1,2), new Position(1, 0),
                new Position(0, 2), new Position(0,1), new Position(2, 2)};

        private static List<Position> PlayTwiceSecondAtOneOne =>
            new List<Position>
                {new Position(0, 0), new Position(1, 1)};

        private static List<Position> PlayOnceAtZeroZero =>
            new List<Position> {new Position(0, 0)};

        private static void PlayTheGivenPositions(List<Position> p)
        {
            foreach (Position position in p)
            {
                game.PlayAt(position);
            }
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