using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public interface IShape
    {
        public double SquareArea(double a, double b);
        public double TriangleArea(double a, double b);
        public double RecAndParallelPerimeter(double a, double b);
        public double TrianglePerimeter(double a, double b, double c);
        public double RombPerimeter(double a);

    }
}
