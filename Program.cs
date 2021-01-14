using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random playerChooser = new Random();
            Console.WriteLine("Welcome to who goes first!");
            Console.WriteLine("How many players are there?");
            string amountOfPlayers = Console.ReadLine();
            int figure = int.Parse(amountOfPlayers);
            int selector = playerChooser.Next(1, figure);
            Console.WriteLine($"Player {selector} goes first!");
            Console.WriteLine("\nPress any key to exit.?");
            Console.ReadKey(true);

        }
    }
}
