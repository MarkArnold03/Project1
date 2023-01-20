using Microsoft.EntityFrameworkCore;
using Project1.CalculatorData;
using Project1.ShapesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Project1.ShapesData
{
    public class ShapesMainMenu
    {
        public static int ShapeMainMenu()
        {
           
                Console.Clear();
                Console.WriteLine("Welcome to the Shapes App!");
                Console.WriteLine("==============================");
                Console.WriteLine("1: Calculate a shape");
                Console.WriteLine("2: Show all shapes");
                Console.WriteLine("3: Update a shape");
                Console.WriteLine("4: Delete a shape");
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
        public static void ShowAll(ApplicationDbContext context)
        {
            var shapes = context.Shapes.ToList();
            if(shapes == null)
            {
                Console.WriteLine("you have no shapes");
            }
            Console.WriteLine("ID\tType\tWidth\tLength\tSide3\tArea\tParimeter\tDate");
            Console.WriteLine("--\t-------------\t------\t-----\t-------\t--------\t--------\t-------");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.ShapeId}\t{shape.Typ}\t{shape.Width}\t{shape.Length}\t{shape.Side3}\t{shape.Area}\t{shape.Perimeter}\t{shape.Date}");
            }
            Console.ReadLine();
        }
        public static bool UpdateShape(ApplicationDbContext context)
        {
            
            try
            {
                Console.WriteLine("\n Enter the Shape ID to update: ");
                Console.WriteLine("ID\tType\tWidth\tLength\tSide3\tArea\tParimeter\tDate");
                Console.WriteLine("--\t-------------\t------\t-----\t-------\t--------\t--------\t-------");
                foreach (var shapes in context.Shapes)
                {
                    Console.WriteLine($"{shapes.ShapeId}\t{shapes.Typ}\t{shapes.Width}\t{shapes.Length}\t{shapes.Side3}\t{shapes.Area}\t{shapes.Perimeter}\t{shapes.Date}");
                }
                var id = int.Parse(Console.ReadLine());
                var shape = context.Shapes.FirstOrDefault(s => s.ShapeId == id);
                if (shape == null)
                {
                    Console.WriteLine("Shape not found.");
                    return false;
                }
                var _shapeServices = new ShapeServices();
                Console.WriteLine("-------Update-------");
                Console.Write("Enter the shape's type: ");
                var type = Console.ReadLine();
                if (type!=shape.Typ)
                {
                    Console.WriteLine("Invalid shape type.");
                    return false;
                }
                Console.Write("Enter the shape's width: ");
                var b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the shape's length: ");
                var h = Convert.ToDouble(Console.ReadLine());
                if (type == "Rectangle" || type == "Parallellogram")
                {
                    var area = _shapeServices.SquareArea(b, h);
                    var perimeter = _shapeServices.RecAndParallelPerimeter(b, h);
                    Console.WriteLine($"Area: {b}(b) * {h}(h) = {area}");
                    Console.WriteLine($"Perimeter: {b}(b) + {h}(h) = {perimeter}");
                    shape.Typ = type;
                    shape.Width = b;
                    shape.Length = h;
                    shape.Area = area;
                    shape.Perimeter = perimeter;
                    shape.Date = DateTime.Today;
                    context.SaveChanges();
                    Console.WriteLine("Calculation updated successfully");
                    return true;
                }
                else if (type == "Triangle")
                {
                    Console.Write("Enter the shape's side3: ");
                    var side3 = Convert.ToDouble(Console.ReadLine());
                    var area = _shapeServices.TriangleArea(b, h);
                    var perimeter = _shapeServices.TrianglePerimeter(b, h, side3);
                    Console.WriteLine($"Area: {b}(b) * {h}h = {area}");
                    Console.WriteLine($"Perimeter: {b}(cm) + {h}(cm) +{side3}(cm) = {perimeter}");

                    shape.Typ = type;
                    shape.Width = b;
                    shape.Length = h;
                    shape.Side3 = side3;
                    shape.Area = area;
                    shape.Perimeter = perimeter;
                    shape.Date = DateTime.Today;
                    context.SaveChanges();
                    Console.WriteLine("Calculation updated successfully");
                    return true;
                }
                else if (type == "Romb")
                {
                    var area = _shapeServices.SquareArea(b, h);
                    var perimeter = _shapeServices.RombPerimeter(b);
                    Console.WriteLine($"Area: {b}(b) * {h}(h) = {area}");
                    Console.WriteLine($"Perimeter: {b}(s) = {perimeter}");
                    shape.Typ = type;
                    shape.Width = b;
                    shape.Length = h;
                    shape.Area = area;
                    shape.Perimeter = perimeter;
                    shape.Date = DateTime.Today;
                    context.SaveChanges();
                    Console.WriteLine("Calculation updated successfully");
                    return true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
                return false;
            }
            Console.WriteLine("Press any key to quit");
            Console.ReadLine();
            return false;
        }
        public static void DeleteShape(ApplicationDbContext context)
        {
            Console.Write("Enter the ID of the shape to delete: ");
            var id = int.Parse(Console.ReadLine());
            var shape = context.Shapes.FirstOrDefault(s => s.ShapeId == id);
            if (shape == null)
            {
                Console.WriteLine("Shape not found.");
                return;
            }

            context.Shapes.Remove(shape);
            context.SaveChanges();

            Console.WriteLine("Shape deleted successfully.");

        }
    }
    }
