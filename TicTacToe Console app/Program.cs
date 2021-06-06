using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeLibrary.Models;

namespace TicTacToe_Console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player 1 please enter your name: ");
            PlayerInfoModel p1 = new PlayerInfoModel();
            p1.UserName = Console.ReadLine();

            Console.WriteLine("Player 2 please enter your name: ");
            PlayerInfoModel p2 = new PlayerInfoModel();
            p2.UserName = Console.ReadLine();




            Console.ReadLine();

        }

        private static string AskForPosition(PlayerInfoModel currentPlayer)
        {
            Console.WriteLine($"{ currentPlayer } please enter you position: ");
        }
    }
}
