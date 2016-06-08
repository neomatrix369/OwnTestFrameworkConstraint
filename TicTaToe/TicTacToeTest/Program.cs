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
            var expectedWinner = "No winner - Game in progress.";
            TicTacToeGame game = new TicTacToeGame();
            if (game.Winner == expectedWinner)
            {
                Console.WriteLine("Success: Winner is " + expectedWinner);
            }
            else
            {
                Console.WriteLine("Failure: Expected winner was " + expectedWinner + ", but winner is " + game.Winner);
            }

            Console.ReadKey();
        }
    }
}
