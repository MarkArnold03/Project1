using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.ShapesData;
using Project1.CalculatorData;
using Project1.Rock_Paper_ScissorsData;

namespace Project1
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Shape> Shapes { get; set; }
        public DbSet<GameResult> Games { get; set; }
        public DbSet<Calculation> Calculations { get; set; }
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Project1;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true");
            }

        }
    }
}
