using System;
using FSPG;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu MainMenu = new Menu();
            Board GameBoard = new Board();
            Settings GameSettings = new Settings();

            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);

            Console.WriteLine("WELCOME TO MINESWEEPER!!");

            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 4);
            Console.WriteLine("Choose an option!");
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 5);
            Console.WriteLine("1) START GAME");
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 6);
            Console.WriteLine("2) Difficulty Setting");
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 7);
            Console.WriteLine("3) EXIT:'(");

            Console.ReadLine();

        }
    }
}
