using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.CalculatorData
{
    public class Operators:ICalculator
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Division(double num1, double num2)
        {
            return num1 / num2;
        }
        public double SquareRoot(double num2)
        {
            
            return Math.Sqrt(num2) ;
        }
        public double Moduls(double num1, double num2)
        {
            return num1 % num2;
        }
    }
}
