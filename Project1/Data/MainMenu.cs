using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Data
{
    public class MainMenu
    {
        public static int showMainMenu()
        {

            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("=========");
            Console.WriteLine("1: Shapes");
            Console.WriteLine("2: Calculator");
            Console.WriteLine("3: Rock Paper Scissors");
            Console.WriteLine("0: Exit");

            var userAnswer = Convert.ToInt32(Console.ReadLine());
            return userAnswer;
        }
    }
}
