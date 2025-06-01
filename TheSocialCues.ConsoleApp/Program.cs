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
        }
    }
}
