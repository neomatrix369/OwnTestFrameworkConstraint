﻿using System;

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

            XWinsIfThreeVerticalXAtY0AreFound();
            Console.ReadKey();
        }

        private static void XWinsIfThreeVerticalXAtY0AreFound()
        {
            CreateEmptyTicTacToeGame();
            var p1 = new Position(0, 0);
            var p2 = new Position(1, 0);
            var p3 = new Position(0, 1);
            var p4 = new Position(1, 1);
            var p5 = new Position(0, 2);
            game.PlayAt(p1);
            game.PlayAt(p2);
            game.PlayAt(p3);
            game.PlayAt(p4);
            game.PlayAt(p5);
            CheckThatTheWinnerIs("X");
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

        private static void CreateEmptyTicTacToeGame()
        {
            game = new TicTacToeGame();
        }

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

        private static void AfterSecondTurnPlayedAtOneOne_ThereIsAnOAtPositionOneOne()
        {
            CreateEmptyTicTacToeGame();
            var p1 = new Position(0, 0);
            var p2 = new Position(1, 0);
            game.PlayAt(p1);
            game.PlayAt(p2);
            CheckPositionForValue(p2, "O");
        }

        private static void AfterFirstTurnPlayedAtZeroZero_AnXCanBeFountAtThisPosition()
        {
            CreateEmptyTicTacToeGame();
            Position p = new Position(0, 0);
            game.PlayAt(p);
            CheckPositionForValue(p, "X");
        }

        private static void CheckPositionForValue(Position p, string expectedValue)
        {
            CheckPositionForValue(p.X, p.Y, expectedValue);
        }

        private static void ThereIsNoWinnerAsLongAsTheGameIsInProcess()
        {
            CreateEmptyTicTacToeGame();
            CheckThatTheWinnerIs("No winner - Game in progress.");
        }
    }
}