using Project1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1;

namespace Project1.Data
{
    public class Build
    {
        public ApplicationDbContext BuildApp()
        {
            var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
            var config = builder.Build();


            var options = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = config.GetConnectionString("DefaultConnection");
            options.UseSqlServer(connectionString);

            using (var dbContext = new ApplicationDbContext(options.Options))
            {

                var dataInitializer = new DataInitializer();
                dataInitializer.MigrateAndSeed(dbContext);


                dbContext.Database.Migrate();
            }

            var dbContextReturned = new ApplicationDbContext(options.Options);
            return dbContextReturned;
        }
    }
}
