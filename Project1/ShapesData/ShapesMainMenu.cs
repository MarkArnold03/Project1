using Microsoft.EntityFrameworkCore;
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
        public static void UpdateShape(ApplicationDbContext context)
        {
            Console.Write("Enter the Shape ID to update: ");
            var id = int.Parse(Console.ReadLine());
            var shape = context.Shapes.FirstOrDefault(s => s.ShapeId == id);
            if (shape == null)
            {
                Console.WriteLine("Shape not found.");
                return;
            }
            var _shapeServices = new ShapeServices();
            Console.WriteLine("-------Update-------");
            Console.WriteLine("write the shapes name to save the result");
            var type = Console.ReadLine();
            Console.WriteLine("write the width");
            var b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("write the length");
            var h = Convert.ToDouble(Console.ReadLine());
            if(shape.Typ== "Rectangle" || shape.Typ == "Parallellogram")
            {
                var area = _shapeServices.SquareArea(b, h);
                var perimeter = _shapeServices.RecAndParallelPerimeter(b, h);
                Console.WriteLine($"Area: {b}(b) * {h}(h) = {area}");
                Console.WriteLine($"Perimeter: {b}(b) + {h}(h) = {perimeter}");
            }
            else if (shape.Typ == "Triangle")
            {
                Console.WriteLine("Give Side3 a value");
                var side3 = 0.0;
                var area = _shapeServices.TriangleArea(b, h);
                side3 = Convert.ToDouble(Console.ReadLine());
                var perimeter = _shapeServices.TrianglePerimeter(b, h, side3);
                Console.WriteLine($"Area: {b}(b) * {h}(h) = {area}");
                Console.WriteLine($"Perimeter: {b}(cm) + {h}(cm) +{side3}(cm) = {perimeter}");
            }
            else if (shape.Typ == "Romb")
            {
                
               var area = _shapeServices.SquareArea(b, h);
               var perimeter = _shapeServices.RombPerimeter(b);
                Console.WriteLine($"Area: {b}(b) * {h}(h) = {area}");
                Console.WriteLine($"Perimeter: {b}(s) = {perimeter}");
            }
            var date = DateTime.Today;
            Console.WriteLine(date.ToString());
            context.Shapes.Update(shape);
            context.SaveChanges();
            //switch (shape.Typ)
            //{
            //    case "Rectangle":
            //        var _shapeServices = new ShapeServices();
            //        Console.WriteLine("-------Rectangle-------");
            //        Console.WriteLine("write the shapes name to save the result");
            //        var type = Console.ReadLine();
            //        Console.WriteLine("Write the width");
            //        var b = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("write the length");
            //        var h = Convert.ToDouble(Console.ReadLine());
            //        var area = _shapeServices.SquareArea(b, h);
            //        var perimeter = _shapeServices.RecAndParallelPerimeter(b, h);
            //        Console.WriteLine($"Area: {b}(b) * {h}(h) = {area}");
            //        Console.WriteLine($"Perimeter: {b}(b) + {h}(h) = {perimeter}");
            //        var date = DateTime.Today;
            //        Console.WriteLine(date.ToString());
            //        context.Shapes.Update(shape);
            //        context.SaveChanges();
            //        break;
            //    case "Parallellogram":
            //        _shapeServices = new ShapeServices();
            //        Console.WriteLine("-------Parallellogram-------");
            //        Console.WriteLine("write the shapes name to save the result");
            //         type = Console.ReadLine();

            //        Console.WriteLine("Write the width");
            //        b = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("write the length");
            //         h = Convert.ToDouble(Console.ReadLine());
            //        area = _shapeServices.SquareArea(b, h);
            //        perimeter = _shapeServices.RecAndParallelPerimeter(b, h);
            //        Console.WriteLine($"Area: {b}(b) * {h}(h) = {area}");
            //        Console.WriteLine($"Perimeter: {b}(b) + {h}(h) = {perimeter}");
            //         date = DateTime.Today;
            //        Console.WriteLine(date.ToString());
            //        context.Shapes.Update(shape);
            //        context.SaveChanges();
            //        break;
            //    case "Triangle":
            //         _shapeServices = new ShapeServices();
            //        Console.WriteLine("-------Triangle-------");
            //        Console.WriteLine("write the shapes name to save the result");
            //        type = Console.ReadLine();
            //        Console.WriteLine("Write the width");
            //         b = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("write the sidelength");
            //         h = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Give Side3 a value");
            //        var side3 = 0.0;
            //        area = _shapeServices.TriangleArea(b, h);
            //        side3 = Convert.ToDouble(Console.ReadLine());
            //        perimeter = _shapeServices.TrianglePerimeter(b, h, side3);
            //        Console.WriteLine($"Area: {b}(b) * {h}(h) = {area}");
            //        Console.WriteLine($"Perimeter: {b}(cm) + {h}(cm) +{side3}(cm) = {perimeter}");
            //         date = DateTime.Today;
            //        Console.WriteLine(date.ToString());
            //        context.Shapes.Update(shape);
            //        context.SaveChanges();
            //        break;
            //    case "Romb":
            //         _shapeServices = new ShapeServices();
            //        Console.WriteLine("-------Romb-------");
            //        Console.WriteLine("write the shapes name to save the result");
            //         type = Console.ReadLine();
            //        Console.WriteLine("Write the width");
            //         b = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("write the sidelength");
            //         h = Convert.ToDouble(Console.ReadLine());
            //         area = _shapeServices.SquareArea(b, h);
            //        perimeter = _shapeServices.RombPerimeter(b);
            //        Console.WriteLine($"Area: {b}(b) * {h}(h) = {area}");
            //        Console.WriteLine($"Perimeter: {b}(s) = {perimeter}");
            //         date = DateTime.Today;
            //        Console.WriteLine(date.ToString());
            //        context.Shapes.Update(shape);
            //        context.SaveChanges();
            //        break;
            //    default:
            //        Console.WriteLine("Invalid shape type.");
            //        return;
            //}



            Console.WriteLine("Shape updated successfully.");
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
