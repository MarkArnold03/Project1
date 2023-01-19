using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.CalculatorData
{
    public class CalculatorMainMenu
    {
        public static int CalculatorsMainMenu()
        {

            Console.Clear();
            Console.WriteLine("Welcome to the Shapes App!");
            Console.WriteLine("==============================");
            Console.WriteLine("1: Make a Calculation");
            Console.WriteLine("2: Show all calculations");
            Console.WriteLine("3: Update a calculation");
            Console.WriteLine("4: Delete a calculation");
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
        public static void ShowCalculations(ApplicationDbContext context)
        {
            var calculations = context.Calculations.ToList();
            if (calculations == null)
            {
                Console.WriteLine("you have no shapes");
            }
            Console.WriteLine("ID\tTal1\tOperator\tTal2\tResult");
            Console.WriteLine("--\t-----\t--------\t-----\t----");
            foreach (var calculation in calculations)
            {
                Console.WriteLine($"{calculation.ID}\t{calculation.Tal1}\t{calculation.Operator}\t{calculation.Tal2}\t{calculation.Result}");
            }
            Console.ReadLine();

           
        }
        public static void UpdateCalculations(ApplicationDbContext context)
        {
            while (true)
            {
                var opService = new Operators();
                Console.Write("Enter Calculation ID: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Invalid ID");
                    continue;
                }
                var calculation = context.Calculations.Find(id);
                if (calculation != null)
                {
                    Console.Write("Enter first number: ");
                    if (!double.TryParse(Console.ReadLine(), out double number1))
                    {
                        Console.WriteLine("Invalid number");
                        continue;
                    }
                    Console.Write("Enter second number: ");
                    if (!double.TryParse(Console.ReadLine(), out double number2))
                    {
                        Console.WriteLine("Invalid number");
                        continue;
                    }
                    Console.Write("Enter operation (+, -, *, /, %, sqrt): ");
                    var operation = Console.ReadLine();
                    double result = 0;
                    switch (operation)
                    {
                        case "+":
                            result = opService.Addition(number1, number2);
                            break;
                        case "-":
                            result = opService.Subtraction(number1, number2);
                            break;
                        case "*":
                            result = opService.Multiplication(number1,number2);
                            break;
                        case "/":
                            result = opService.Division(number1,number2);
                            break;
                        case "%":
                            result = opService.Moduls(number1,number2);
                            break;
                        case "sqrt":
                            if (number1 < 0)
                            {
                                Console.WriteLine("Invalid number for square root");
                                continue;
                            }
                            result = opService.SquareRoot(number1);
                            break;
                       default:
                            Console.WriteLine("Invalid operation");
                            continue;
                    }
                    calculation.Tal1 = number1;
                    calculation.Tal2 = number2;
                    calculation.Operator = operation;
                    calculation.Result = result;
                    calculation.Date = DateTime.Today;
                    context.SaveChanges();
                    Console.WriteLine("Calculation updated successfully");
                    break;
                }
            }
        }
        public static void DeleteCalculation(ApplicationDbContext context)
        {
            while (true)
            {
                Console.Write("Enter Calculation ID: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Invalid ID");
                    continue;
                }
                var calculation = context.Calculations.Find(id);
                if (calculation != null)
                {
                    context.Remove(calculation);
                    context.SaveChanges();
                    Console.WriteLine("Calculation deleted successfully");
                    break;
                }
                else
                {
                    Console.WriteLine("Calculation not found");
                }
            }
            
        }
    }
}
