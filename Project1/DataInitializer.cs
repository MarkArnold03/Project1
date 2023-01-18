using Microsoft.EntityFrameworkCore;
using Project1.CalculatorData;
using Project1.ShapesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace Project1
{
    public class DataInitializer
    {
        public void MigrateAndSeed(ApplicationDbContext dbContext)
        {
            dbContext.Database.Migrate();
            ShapeData(dbContext);
            CalculatorData(dbContext);
           dbContext.SaveChanges();
        }

        private void ShapeData(ApplicationDbContext dbContext)
        {

            if (!dbContext.Shapes.Any(s => s.ShapeId == 1))
            {
                dbContext.Shapes.Add(new Shape
                {
                    Typ = "Triangle",
                    Width = 5,
                    Length = 4,
                    Side3 = 5,
                    Area = 10,
                    Perimeter = 14,
                    Date = DateTime.Today,


                });
            }
            if (!dbContext.Shapes.Any(s => s.ShapeId == 2))
            {
                dbContext.Shapes.Add(new Shape
                {
                    Typ = "Romb",
                    Width = 2,
                    Length = 9,
                    Area = 18,
                    Perimeter = 8,
                    Date = DateTime.Today,


                });
            }
            if (!dbContext.Shapes.Any(s => s.ShapeId == 3))
            {
                dbContext.Shapes.Add(new Shape
                {
                    Typ = "Rectangle",
                    Width=5,
                    Length=2,
                    Area = 10,
                    Perimeter = 14,
                    Date = DateTime.Today,


                });
            }
            if (!dbContext.Shapes.Any(s => s.ShapeId == 4))
            {
                dbContext.Shapes.Add(new Shape
                {
                    Typ = "Parallellogram",
                    Width=5,
                    Length=4,
                    Area = 20,
                    Perimeter = 18,
                    Date = DateTime.Today,


                });
            }
            dbContext.SaveChanges();

        }
        private void CalculatorData(ApplicationDbContext dbContext)
        {
            if (!dbContext.Calculations.Any(c => c.ID == 1))
            {
                dbContext.Calculations.Add(new Calculation
                {
                   Tal1= 1,
                   Tal2= 2,
                   Operator="+",
                   Result = 3,
                   Date = DateTime.Today,
                });
            }
            if (!dbContext.Calculations.Any(c => c.ID == 1))
            {
                dbContext.Calculations.Add(new Calculation
                {
                    Tal1 = 4,
                    Tal2 = 2,
                    Operator = "-",
                    Result = 2,
                    Date = DateTime.Today,
                });
            }
            if (!dbContext.Calculations.Any(c => c.ID == 1))
            {
                dbContext.Calculations.Add(new Calculation
                {
                    Tal1 = 10,
                    Tal2 = 2,
                    Operator = "*",
                    Result = 20,
                    Date = DateTime.Today,
                });
            }
            if (!dbContext.Calculations.Any(c => c.ID == 1))
            {
                dbContext.Calculations.Add(new Calculation
                {
                    Tal1 = 10,
                    Tal2 = 2,
                    Operator = "/",
                    Result = 5,
                    Date = DateTime.Today,
                });
            }

            dbContext.SaveChanges();
        }

    }
}
