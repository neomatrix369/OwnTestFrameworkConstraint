using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ThereIsNoWinnerAsLongAsTheGameIsInProcess();

            AfterFirstTurnPlayedAtZeroZero_AnXCanBeFountAtThisPosition();


            Console.ReadKey();
        }

        private static void AfterFirstTurnPlayedAtZeroZero_AnXCanBeFountAtThisPosition()
        {
            var expectedValue = "X";
            TicTacToeGame game = new TicTacToeGame();
            game.playAt(0, 0);

            if (game.ValueAt(0, 0) == expectedValue)
            {
                Console.WriteLine("Success: Value at 0, 0 is " + expectedValue + " as expected.");
            }
            else
            {
                Console.WriteLine("Failure: Expected value at 0, 0 was " + expectedValue + ", but found " + game.ValueAt(0, 0));
            }
        }

        private static void ThereIsNoWinnerAsLongAsTheGameIsInProcess()
        {
            var expectedWinner = "No winner - Game in progress.";
            TicTacToeGame game = new TicTacToeGame();
            if (game.Winner == expectedWinner)
            {
                Console.WriteLine("Success: Winner is " + expectedWinner);
            }
            else
            {
                Console.WriteLine("Failure: Expected winner was " 
                    + expectedWinner + ", but winner is " + game.Winner);
            }
        }
    }
}
