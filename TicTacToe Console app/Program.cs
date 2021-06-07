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

            PlayerInfoModel p1 = GetUserNameInfo("Player 1");
            PlayerInfoModel p2 = GetUserNameInfo("Player 2");

            string currentPlayer = p1.UserName;

            string shot = AskForPosition(currentPlayer);

            string row = "";
            int column = 0;
            try
            {
                (row, column) = SplitShotIntoRowAndColumn(shot);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid shot location. Please try again.");
            }

            DrawGrid(row, column);

            Console.ReadLine();

        }

        private static PlayerInfoModel GetUserNameInfo(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine($"{ playerTitle } please enter your name: ");

            output.UserName = Console.ReadLine();
            output.UserName = output.UserName.First().ToString().ToUpper() + output.UserName.Substring(1);

            return output;
        }

        private static string AskForPosition(string currentPlayer)
        {
            Console.WriteLine($"Hi { currentPlayer } please enter your shot position (ie. A1): ");
            string output = Console.ReadLine().ToUpper();

            return output;
        }


        private static void DrawGrid(string row, int column)
        {
            Console.WriteLine();
            Console.WriteLine(" | |  A");
            Console.WriteLine("-------");
            Console.WriteLine(" | |  B");
            Console.WriteLine("-------");
            Console.WriteLine(" | |  C");
            ConsoleWriteLine();
            Console.WriteLine("1 2 3");

            Console.WriteLine();

            Console.WriteLine($"Row is: { row } and the column is : { column }");
        }

        private static (string row, int column) SplitShotIntoRowAndColumn(string shot)
        {
            string row = "";
            int column = 0;

            if (shot.Length != 2)
            {
                throw new ArgumentException("This is an invalid shot type.");
            }

            char[] shotArray = shot.ToArray();
            row = shotArray[0].ToString();
            column = int.Parse(shotArray[1].ToString());

            return (row, column);
        }

        private static string AskForPosition(PlayerInfoModel currentPlayer)
        {
            Console.WriteLine($"{ currentPlayer.UserName } please enter you position: ");
            string output = Console.ReadLine();

            return output;
        }
    }
}
