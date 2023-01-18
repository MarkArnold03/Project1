using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Shape> Shapes { get; set; }
        //public DbSet<StenSaxPåse> Spelningar { get; set; }
        //public DbSet<MiniRäknare> Räkningar { get; set; }
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
