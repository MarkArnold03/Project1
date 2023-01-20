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
            while (true)
            {
                var resultPrompt = "";
                double winRate;
                var result = new Result();
                var userChoise = new Choice();
                Random rnd = new Random();
                var values = (Choice[])Enum.GetValues(typeof(Choice));
                var index = rnd.Next(values.Length);
                var computerChoice = values[index];
                Console.Clear();
                Console.Write("Enter your choice\n1: rock\n2: paper\n3: scissors\n0: back ");
                var input = Console.ReadLine();
                bool success = int.TryParse(input, out int output);
                if (success)
                {
                    if (output == 0)
                    {
                        break;
                    }

                    switch (output)
                    {
                        case 1:
                            userChoise = Choice.Rock;
                            if (computerChoice == Choice.Rock)
                            {
                                resultPrompt = $"You Draw";
                                result = Result.Draw;
                            }

                            if (computerChoice == Choice.Paper)
                            {
                                resultPrompt = $"You Lost";
                                result = Result.Loss;
                            }

                            if (computerChoice == Choice.Scissor)
                            {
                                resultPrompt = $"You Won";
                                result = Result.Win;
                            }
                            break;
                        case 2:
                            userChoise = Choice.Paper;
                            if (computerChoice == Choice.Rock)
                            {
                                resultPrompt = $"You Won";
                                result = Result.Win;
                            }

                            if (computerChoice == Choice.Paper)
                            {
                                resultPrompt = $"You Draw";
                                result = Result.Draw;
                            }

                            if (computerChoice == Choice.Scissor)
                            {
                                resultPrompt = $"You Lost";
                                result = Result.Loss;
                            }
                            break;
                        case 3:
                            userChoise = Choice.Scissor;
                            if (computerChoice == Choice.Rock)
                            {
                                resultPrompt = $"You Lost";
                                result = Result.Loss;
                            }

                            if (computerChoice == Choice.Paper)
                            {
                                resultPrompt = $"You Won";
                                result = Result.Win;
                            }

                            if (computerChoice == Choice.Scissor)
                            {
                                resultPrompt = $"You Draw";
                                result = Result.Draw;
                            }
                            break;
                    }
                    var userWins = context.Games.Where(g => g.Result == Result.Win).Count();
                    var totalGames = context.Games.Count();
                    if (totalGames != 0)
                    {
                        winRate = Convert.ToDouble((userWins / (double)totalGames) * 100);
                    }
                    else
                    {
                        if (result == Result.Loss)
                        {
                            winRate = 0;
                        }
                        else
                        {
                            winRate = 100;
                        }
                    }
                    GameResult game = new GameResult
                    {
                        UserChoice = userChoise,
                        ComputerChoice = computerChoice,
                        Result = result,
                        Date = DateTime.Now,
                        WinRate = winRate
                    };
                    context.Games.Add(game);
                    context.SaveChanges();
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"{resultPrompt}, do you want to play again? (y/n)");
                        var readKey = Console.ReadKey().KeyChar;
                        if (readKey == 'y')
                        {
                            break;
                        }
                        if (readKey == 'n')
                        {
                            return;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("incorrect choice try again");
                }
            }
        }



    }
    
    
}
        
