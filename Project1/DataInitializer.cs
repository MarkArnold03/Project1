using Microsoft.EntityFrameworkCore;
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
            //CustomerData(dbContext);
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


        }
        //private void CustomerData(ApplicationDbContext dbContext)
        //{
        //    if (!dbContext.Customers.Any(c => c.CustomerId == 1))
        //    {
        //        dbContext.Customers.Add(new Customer
        //        {
        //            Name = "John Smith",
        //            Email = "john@example.com",
        //            PhoneNumber = "123-456-7890",

        //        });
        //    }
        //    if (!dbContext.Customers.Any(c => c.CustomerId == 2))
        //    {
        //        dbContext.Customers.Add(new Customer
        //        {
        //            Name = "Jane Doe",
        //            Email = "jane@example.com",
        //            PhoneNumber = "123-456-7891",

        //        });
        //    }
        //    if (!dbContext.Customers.Any(c => c.CustomerId == 3))
        //    {
        //        dbContext.Customers.Add(new Customer
        //        {
                    
        //            Name = "Bob Johnson",
        //            Email = "bob@example.com",
        //            PhoneNumber = "123-456-7892",

        //        });
        //    }
        //    if (!dbContext.Customers.Any(c => c.CustomerId == 4))
        //    {
        //        dbContext.Customers.Add(new Customer
        //        {
                    
        //            Name = "Sally Smith",
        //            Email = "sally@example.com",
        //            PhoneNumber = "123-456-7893",

        //        });
        //    }
        //    dbContext.SaveChanges();
        //}

    }
}
