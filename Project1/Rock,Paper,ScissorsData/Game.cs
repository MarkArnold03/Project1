using Microsoft.EntityFrameworkCore;
using Project1.ShapesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Rock_Paper_ScissorsData
{
    public class Game
    {
        
           
        public static void GameDisplay(ApplicationDbContext context)
        { 
            int totalGames = context.Games.Count(); 
            double userWins = context.Games.Where(g => g.Result == "You win!").Count();
            while (true)
            {
                Console.Write("\nEnter your choice (rock, paper, or scissors): ");
                string userChoice = Console.ReadLine();
                if (userChoice != "rock" || userChoice != "paper" || userChoice != "scissor")
                {
                    Console.WriteLine("incorrect choice try again");
                    return;
                }

                string[] options = { "rock", "paper", "scissors" };
                Random rnd = new Random();
                int computerChoiceIndex = rnd.Next(options.Length);
                string computerChoice = options[computerChoiceIndex];

                string result;
                double winRate;
                
                if (userChoice == "rock" && computerChoice == "scissors" ||
                    userChoice == "paper" && computerChoice == "rock" ||
                    userChoice == "scissors" && computerChoice == "paper")
                {
                    result = "You win!";
                    userWins++;
                }
               
                else if (userChoice == computerChoice)
                {
                    result = "Tie!";
                }
                else
                {
                    result = "You lose.";
                } 
                

                winRate = Convert.ToDouble((userWins / (double)totalGames) * 100);

                GameResult game = new GameResult
                {
                    UserChoice = userChoice,
                    ComputerChoice = computerChoice,
                    Result = result,
                    Date = DateTime.Now,
                    WinRate = winRate
                };

                context.Games.Add(game);
                context.SaveChanges();
                totalGames++;


                Console.WriteLine("\nTotal games: " + totalGames);
                Console.WriteLine("User wins: " + userWins);
                Console.WriteLine("User win rate: " + winRate + "%");
                Console.WriteLine("Do you want to play again? (y/n)");
                string playAgain = Console.ReadLine();
                if (playAgain == "n")
                {
                    break;
                }
            }
        }


       
    }
    
    
}
        
