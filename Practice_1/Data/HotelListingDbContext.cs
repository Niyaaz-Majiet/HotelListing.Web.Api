using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Practice_1.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions<HotelListingDbContext> options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                  new Country { Id = 1, Name = "South Africa", ShortName = "ZA" },
                  new Country { Id = 2, Name = "America", ShortName = "USA" },
                  new Country { Id = 3, Name = "New Zealand", ShortName = "NZ" }
                );

            modelBuilder.Entity<Hotel>().HasData(
               new Hotel { Id = 1, Name = "The Wex", Address = "23 Archers Green", Rating = 4.4, CountryId = 1 },
               new Hotel { Id = 2, Name = "The Son", Address = "23 Tennyson Street", Rating = 2.4, CountryId = 2 },
               new Hotel { Id = 3, Name = "The Sir", Address = "23 Pine Avenue", Rating = 5.0, CountryId = 3 }
             );
        }
    }
}

