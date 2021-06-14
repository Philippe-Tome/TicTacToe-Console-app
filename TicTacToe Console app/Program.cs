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
            char[] Row_A = new char[3];
            char[] Row_B = new char[3];
            char[] Row_C = new char[3];

            int count = 0;

            PlayerInfoModel p1 = GetUserNameInfo("Player 1");
            PlayerInfoModel p2 = GetUserNameInfo("Player 2");

            int currentPlayer = 1;
            string currentPlayerName = p1.UserName;

            while (count != 9)
            {
                string shot = AskForPosition(currentPlayerName);

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


                RecordPlayedPositions(currentPlayer, row, column, Row_A, Row_B, Row_C);

                DrawGrid(Row_A, Row_B, Row_C);

                if (currentPlayer == 1)
                {
                    currentPlayer = 2;
                    currentPlayerName = p2.UserName;
                }
                else
                {
                    currentPlayer = 1;
                    currentPlayerName = p1.UserName;
                }
            }

            Console.ReadLine();

        }

        private static void RecordPlayedPositions(int currentPlayer, string row, int column, char[] Row_A, char[] Row_B, char[] Row_C)
        {
            char marker = 'X';

            if (currentPlayer ==2)
            {
                marker = 'O';
            }

            switch (row) {
                case "A":
                    Row_A[column - 1] = marker;
                    break;
                case "B":
                    Row_B[column - 1] = marker;
                    break;
                case "C":
                    Row_C[column - 1] = marker;
                    break;
                default:
                    Console.WriteLine("Row is not A, B or C!!!");
                    break;
            }
     
        }

        private static PlayerInfoModel GetUserNameInfo(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine($"{ playerTitle } please enter your name: ");

            output.UserName = Console.ReadLine();
            output.UserName = output.UserName.First().ToString().ToUpper() + output.UserName.Substring(1);

            return output;
        }

        private static string AskForPosition(string currentPlayerName)
        {
            Console.WriteLine($"Hi { currentPlayerName } please enter your shot position (ie. A1): ");
            string output = Console.ReadLine().ToUpper();

            return output;
        }


        private static void DrawGrid(char[] Row_A, char[] Row_B, char[] Row_C)
        {
            Console.WriteLine();
            Console.Write("A ");

            foreach (var item in Row_A)
            {
                if (item == 'X' || item == 'O')
                {
                    Console.Write(item + " "); 
                }
                else
                {
                    Console.Write("_ ");
                }
            }

            Console.WriteLine();
            Console.Write("B ");

            foreach (var item in Row_B)
            {
                if (item == 'X' || item == 'O')
                {
                    Console.Write(item + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }

            Console.WriteLine();
            Console.Write("C ");

            foreach (var item in Row_C)
            {
                if (item == 'X' || item == 'O')
                {
                    Console.Write(item + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            //Console.WriteLine("1 2 3");

            //Console.WriteLine();
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
