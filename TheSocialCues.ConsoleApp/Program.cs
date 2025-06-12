// TheSocialCues.ConsoleApp/Program.cs
using System;
using TheSocialCues.Core;

namespace TheSocialCues.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Social Cues!");
            // You can plug the GameEngine here later
            Guest guest = new Guest("Anna");

            Console.WriteLine($"Guest's name is {guest.Name} and the current phase is {guest.CurrentLevel}");

            //TODO: Implement the name validation loop here like this:
            //string? name;
            //do
            //{
            //    Console.Write("Enter your name: ");
            //    name = Console.ReadLine();

            //    if (string.IsNullOrWhiteSpace(name))
            //    {
            //        Console.WriteLine("⚠️  Please enter a valid name.");
            //    }

            //} while (string.IsNullOrWhiteSpace(name));

            //var player = new Player(name);

            //Console.WriteLine($"Welcome, {player.Name}!");
        }
    }
}
