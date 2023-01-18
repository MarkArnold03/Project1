using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.CalculatorData
{
    public interface ICalculator
    {
        public double Addition(double a, double b);
        public double Subtraction(double a, double b);
        public double Multiplication(double a, double b);
        public double Division(double a, double b);
        public double Moduls(double a, double b);
        public double SquareRoot(double a);
    }
}
