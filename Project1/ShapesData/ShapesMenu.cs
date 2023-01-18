using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.ShapesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.ShapesData
{
    public class ShapesMenu 
    {
        
       
        public static void ShapeMenu(ApplicationDbContext dbContext)      
        {
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose a Shape To Caculate");
                Console.WriteLine("==============================");
                Console.WriteLine("1: Parallellogram");
                Console.WriteLine("2: Rectangle");
                Console.WriteLine("3: Romb");
                Console.WriteLine("4: Triangle");
                Console.WriteLine("0: ack to main menu");
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
                        ParallelCalculation(dbContext);
                        break;
                    case 2:
                        Console.Clear();
                        RectangleCalculation(dbContext);
                        break;
                    case 3:
                        Console.Clear();
                        RombCalculation(dbContext);
                        break;
                    case 4:
                        Console.Clear();
                        TriangleCalculation(dbContext);
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;

                }
               
                
            }
        }
        public static void ParallelCalculation(ApplicationDbContext context)
        {
            var _shapeServices = new ShapeServices();
            Console.WriteLine("-------Parallellogram-------");
            Console.WriteLine("write the shapes name to save the result");
            var type = Console.ReadLine();
            
            Console.WriteLine("Write the width");
            var b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("write the length");
            var h = Convert.ToDouble(Console.ReadLine());
            var area =_shapeServices.SquareArea(b, h);
            var perimeter = _shapeServices.RecAndParallelPerimeter(b,h);
            Console.WriteLine($"Area: {b}(b) * {h}(h) = {area}");
            Console.WriteLine($"Perimeter: {b}(b) + {h}(h) = {perimeter}");
            var date = DateTime.Today;
            Console.WriteLine(date.ToString());

            context.Shapes.Add(new Shape
            {

                Date = DateTime.Today,
                Width=b,
                Length = h,
                Typ = type,
                Area = area,
                Perimeter = perimeter,
            });
            context.SaveChanges();
            Console.ReadLine();
        }
        public static void RectangleCalculation(ApplicationDbContext context)
        {
            var _shapeServices = new ShapeServices();
            Console.WriteLine("-------Rectangle-------");
            Console.WriteLine("write the shapes name to save the result");
            var type = Console.ReadLine();
            Console.WriteLine("Write the width");
            var b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("write the length");
            var h = Convert.ToDouble(Console.ReadLine());
            var area = _shapeServices.SquareArea(b, h);
            var perimeter = _shapeServices.RecAndParallelPerimeter(b, h);
            Console.WriteLine($"Area: {b}(b) * {h}(h) = {area}");
            Console.WriteLine($"Perimeter: {b}(b) + {h}(h) = {perimeter}");
            var date = DateTime.Today;
            Console.WriteLine(date.ToString());


            context.Shapes.Add(new Shape
            {

                Date = DateTime.Today,
                Width = b,
                Length = h,
                Typ = type,
                Area = area,
                Perimeter = perimeter,
            });
            context.SaveChanges();
            Console.ReadLine();
        }
        public static void RombCalculation(ApplicationDbContext context)
        {
            var _shapeServices = new ShapeServices();
            Console.WriteLine("-------Romb-------");
            Console.WriteLine("write the shapes name to save the result");
            var type = Console.ReadLine();
            Console.WriteLine("Write the width");
            var b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("write the sidelength");
            var h = Convert.ToDouble(Console.ReadLine());
            var area = _shapeServices.SquareArea(b, h);
            var perimeter = _shapeServices.RombPerimeter(b);
            Console.WriteLine($"Area: {b}(b) * {h}(h) = {area}");
            Console.WriteLine($"Perimeter: {b}(s) = {perimeter}");
            var date = DateTime.Today;
            Console.WriteLine(date.ToString());

            context.Shapes.Add(new Shape
            {

                Date = DateTime.Today,
                Width = b,
                Length = h,
                Typ = type,
                Area = area,
                Perimeter = perimeter,
            });
            context.SaveChanges();
            Console.ReadLine();
        }
        public static void TriangleCalculation(ApplicationDbContext context)
        {
            var _shapeServices = new ShapeServices();
            Console.WriteLine("-------Triangle-------");
            Console.WriteLine("write the shapes name to save the result");
            var type = Console.ReadLine();
            Console.WriteLine("Write the width");
            var b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("write the sidelength");
            var h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give Side3 a value");
            var side3 = 0.0;
            var area = _shapeServices.TriangleArea(b, h);
            side3 = Convert.ToDouble(Console.ReadLine());
            var perimeter = _shapeServices.TrianglePerimeter(b, h, side3);
            Console.WriteLine($"Area: {b}(b) * {h}(h) = {area}");
            Console.WriteLine($"Perimeter: {b}(cm) + {h}(cm) +{side3}(cm) = {perimeter}");
            var date = DateTime.Today;
            Console.WriteLine(date.ToString());

            context.Shapes.Add(new Shape
            {

                Date = DateTime.Today,
                Width=b,
                Length=h,
                Side3=side3,
                Typ = type,
                Area = area,
                Perimeter = perimeter,
            });
            context.SaveChanges();
            Console.ReadLine();
        }
    }
}
