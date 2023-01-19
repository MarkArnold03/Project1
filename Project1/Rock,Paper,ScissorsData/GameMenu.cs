using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Rock_Paper_ScissorsData
{
    public class GameMenu
    {
        public static int GamesMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Rock,Paper,Scissors Game!");
            Console.WriteLine("==============================");
            Console.WriteLine("1: Start a Game");
            Console.WriteLine("2: Show all Games");
            Console.WriteLine("0: Exit");
            int output;
            while (true)
            {
                var input = Console.ReadLine();
                var succssess = int.TryParse(input, out output);
                if (succssess)
                {
                    break;
                }
                Console.WriteLine("Please choose a number");
            }
            Console.WriteLine();
            return output;
        }
        public static void ShowAllResults(ApplicationDbContext context)
        {
            var games = context.Games.ToList();
            if (!games.Any())
            {
                Console.WriteLine("No games have been played yet.");
            }
            else
            {
                foreach (var game in games)
                {
                    Console.WriteLine("User choice: " + game.UserChoice + " Computer choice: " + game.ComputerChoice + " Result: " + game.Result + " Date: " + game.Date + " Win Rate: " + game.WinRate);
                }
            }
            Console.WriteLine("Press any key to return to menu");
            Console.ReadLine();
        }
    }
}
