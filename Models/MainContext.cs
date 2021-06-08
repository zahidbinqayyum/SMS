using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SMS.Models.TradingPartner;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Models
{
    public class MainContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();

                var connectionString = configuration.GetConnectionString("Default");

                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }



        public virtual DbSet<TradePartner> TradePartner { get; set; }
        public virtual DbSet<TPCategory> TPCategory { get; set; }
        public virtual DbSet<TPAllotedCategory> TPAllotedCategory { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TPAllotedCategory>()
                .HasKey(o => o.TPCatId );


            modelBuilder.Entity<TPAllotedCategory>().HasKey(a => new
            {
                a.Id,
                a.TPId,
                a.TPCatId
            });


        }
    }
}
