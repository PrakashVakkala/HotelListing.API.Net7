using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext:DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<Hotel> hotels { get; set; }
        public DbSet<Country> countrys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "America",
                    shortname="amca"
                },
                new Country
                {
                    Id = 2,
                    Name = "Japan",
                    shortname = "jp"
                },
                 new Country
                 {
                     Id = 3,
                     Name = "India",
                     shortname = "ind"
                 },
                 new Country
                 {
                     Id = 4,
                     Name = "west",
                     shortname = "we"
                 }

                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                { 
                  Id=1,
                  Name="Chocolate point",
                  Address="newyork",
                  Rating=10,
                  CountryId=1
                
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Palki",
                    Address = "Banglore",
                    Rating = 8,
                    CountryId = 3

                },
                new Hotel
                {
                    Id = 3,
                    Name = "Dominos",
                    Address = "hyderabad",
                    Rating = 7,
                    CountryId = 1

                },
                new Hotel
                {
                    Id = 4,
                    Name = "dom",
                    Address = "telangana",
                    Rating = 10,
                    CountryId = 4

                }


                );
        }
    }
}
