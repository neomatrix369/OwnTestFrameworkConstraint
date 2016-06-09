using System;
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
            XWinsIfThreeHorizontalXsAreFoundAtColumnZero();

            Console.ReadKey();
        }

        #region Tests
        private static void ThereIsNoWinnerAsTheGameBegins()
        {
            CreateEmptyTicTacToeGame();
            CheckThatTheWinnerIs("No winner - Game in progress.");
        }

        private static void AfterFirstTurnPlayedAtZeroZero_ThereIsAnXAtpositionZeroZero()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(PlayOnceAtZeroZero);
            CheckPositionForValue(new Position(0, 0), "X");
        }

        private static void AfterSecondTurnPlayedAtOneOne_ThereIsAnOAtPositionOneOne()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(PlayTwiceSecondAtOneOne);
            CheckPositionForValue(new Position(1,1), "O");
        }

        private static void XWinsIfThreeVerticalXsAreFoundAtColumnZero()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(XWinsWithThreeXsAtColumnZero);
            CheckThatTheWinnerIs("X");
        }

        private static void OWinsIfThreeVerticalOsAreFoundAtColumnOne()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(XWinsWithThreeXsAtColumnOne);
            CheckThatTheWinnerIs("O");
        }

        private static void XWinsIfThreeHorizontalXsAreFoundAtColumnZero()
        {
            CreateEmptyTicTacToeGame();
            PlayTheGivenPositions(XWinsWithThreeXsAtRowZero);
            CheckThatTheWinnerIs("X");
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
        private static List<Position> XWinsWithThreeXsAtColumnOne =>
            new List<Position>
                {new Position(0, 0), new Position(1, 0), new Position(0, 1),
                new Position(1, 1), new Position(2, 0), new Position(1, 2)};

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
        private static void CheckThatTheWinnerIs(string expectedWinner)
        {
            if (game.Winner == expectedWinner)
            {
                Console.WriteLine("Success: Winner is " + expectedWinner);
            }
            else
            {
                Console.WriteLine("Failure: Expected winner was " + expectedWinner + ", but winner is " + game.Winner);
            }
        }

        private static void CheckPositionForValue(Position p, string expectedValue)
        {
            if (game.ValueAt(p) == expectedValue)
            {
                Console.WriteLine("Success: Value at " + p.X + ", " + p.Y + " is " + expectedValue + " as expected.");
            }
            else
            {
                Console.WriteLine("Failure: Expected value at " + p.X + ", " + p.Y + " was " + expectedValue + ", but found " +
                                  game.ValueAt(p));
            }
        }

        #endregion




    }
}