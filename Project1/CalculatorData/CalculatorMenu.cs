using Project1.ShapesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.CalculatorData
{
    public class CalculatorMenu
    {
        public static void CalculatorsMenu(ApplicationDbContext dbContext)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose a Operator to use");
                Console.WriteLine("==============================");
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");
                Console.WriteLine("5: Moduls");
                Console.WriteLine("6: Square Root");

                Console.WriteLine("press enter to go back to main menu");
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
                


                switch (output)
                {
                    case 1:
                        Console.Clear();
                        Addition(dbContext);
                        break;
                    case 2:
                        Console.Clear();
                        Subtraction(dbContext);
                        break;
                    case 3:
                        Console.Clear();
                        Multiplication(dbContext);
                        break;
                    case 4:
                        Console.Clear();
                        Division(dbContext);
                        break;
                    case 5:
                        Console.Clear();
                        Moduls(dbContext);
                        break;
                    case 6:
                        Console.Clear();
                        SquareRoot(dbContext);
                        break;

                }
                if (output == 0)
                {
                    Console.Clear();
                    break;
                }

            }
        }
        public static void Addition(ApplicationDbContext context)
        {
            var opService = new Operators();
            var calc = new Calculation();
            var res = calc.Result;
            Console.WriteLine("Addition");
            Console.WriteLine("Write you first number");
            var input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write you second number");
            var input2 = Convert.ToInt32(Console.ReadLine());
            res = opService.Addition(input1,input2);
            Console.WriteLine($"{input1} + {input2} = {res}");
            var calculation = new Calculation
            {
                Tal1 = input1,
                Tal2 = input2,
                Operator = "+",
                Result = res,
                Date = DateTime.Now
            };
            context.Calculations.Add(calculation);
            context.SaveChanges();
        }
        public static void Subtraction(ApplicationDbContext context)
        {
            var opService = new Operators();
            var calc = new Calculation();
            var res = calc.Result;
            Console.WriteLine("Addition");
            Console.WriteLine("Write you first number");
            var input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write you second number");
            var input2 = Convert.ToInt32(Console.ReadLine());
            res = opService.Subtraction(input1, input2);
            Console.WriteLine($"{input1} - {input2} = {res}");
            var calculation = new Calculation
            {
                Tal1 = input1,
                Tal2 = input2,
                Operator = "-",
                Result = res,
                Date = DateTime.Now
            };
            context.Calculations.Add(calculation);
            context.SaveChanges();
        }
        public static void Multiplication(ApplicationDbContext context)
        {
            var opService = new Operators();
            var calc = new Calculation();
            var res = calc.Result;
            Console.WriteLine("Addition");
            Console.WriteLine("Write you first number");
            var input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write you second number");
            var input2 = Convert.ToInt32(Console.ReadLine());
            res = opService.Multiplication(input1,input2);
            Console.WriteLine($"{input1} * {input2} = {res}");
            var calculation = new Calculation
            {
                Tal1 = input1,
                Tal2 = input2,
                Operator = "*",
                Result = res,
                Date = DateTime.Now
            };
            context.Calculations.Add(calculation);
            context.SaveChanges();
        }
        public static void Division(ApplicationDbContext context)
        {
            var opService = new Operators();
            var calc = new Calculation();
            var res = calc.Result;
            Console.WriteLine("Addition");
            Console.WriteLine("Write you first number");
            var input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write you second number");
            var input2 = Convert.ToInt32(Console.ReadLine());
            res = opService.Division(input1, input2);
            Console.WriteLine($"{input1} / {input2} = {res}");
            var calculation = new Calculation
            {
                Tal1 = input1,
                Tal2 = input2,
                Operator = "/",
                Result = res,
                Date = DateTime.Now
            };
            context.Calculations.Add(calculation);
            context.SaveChanges();
        }
        public static void Moduls(ApplicationDbContext context)
        {
            var opService = new Operators();
            var calc = new Calculation();
            var res = calc.Result;
            Console.WriteLine("Addition");
            Console.WriteLine("Write you first number");
            var input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write you second number");
            var input2 = Convert.ToInt32(Console.ReadLine());
            res = opService.Moduls(input1, input2);
            
            Console.WriteLine($"{input1} % {input2} = {res}");
            var calculation = new Calculation
            {
                Tal1 = input1,
                Tal2 = input2,
                Operator = "%",
                Result = res,
                Date = DateTime.Now
            };
            context.Calculations.Add(calculation);
            context.SaveChanges();
        }
        public static void SquareRoot(ApplicationDbContext context)
        {
            var opService = new Operators(); 
            var calc = new Calculation();
            var res = calc.Result;
            Console.WriteLine("Addition");
            Console.WriteLine("Write you number");
            var input1 = Convert.ToInt32(Console.ReadLine());
            res = opService.SquareRoot(input1);
            Console.WriteLine($"√{input1} = {res}");
            var calculation = new Calculation
            {
                Tal1 = input1,
                Operator = "sqrt",
                Result = res,
                Date = DateTime.Now
            };
            context.Calculations.Add(calculation);
            context.SaveChanges();
        }

    }
}
