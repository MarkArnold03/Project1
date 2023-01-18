using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.ShapesData
{
    public class ShapeServices : IShape
    {
        public double SquareArea(double a, double b)
        {
            return a * b;
        }
        public double TriangleArea(double a, double b)
        {
            return (a * b)/2;
        }
        public double RecAndParallelPerimeter(double a,double b)
        {
            return (a * 2) + (b * 2);
        }
        public double TrianglePerimeter(double a, double b, double c)
        {
            return a + b + c;
        }
        public double RombPerimeter(double a)
        {
            return a * 4;
        }
    }
}
