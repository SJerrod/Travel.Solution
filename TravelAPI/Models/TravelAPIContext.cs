using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Models
{
    public class TravelAPIContext : DbContext
    {
        public TravelAPIContext(DbContextOptions<TravelAPIContext> options)
            :base(options)
        {
        }

        public DbSet<Destination> Destinations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Destination>()
                .HasData(
                    new Destination { DestinationId = 1, Country = "United States", City = "Orlando", Rating = 3, Review = "Disney world and Universal Studios all in one city, Whats not to like", Date = "06/14/2019"},
                    new Destination { DestinationId = 2, Country = "United Kingdom", City = "London", Rating = 4, Review = "Couldnt get the Royal Guards to laugh, but at least I didnt wind up in the tower of London", Date = "10/28/2020"},
                    new Destination { DestinationId = 3, Country = "Japan", City = "Tokyo", Rating = 5, Review = "The cherry blossom festival is a MUST SEE", Date = "04/14/2018"},
                    new Destination { DestinationId = 4, Country = "Australia", City = "Sydney", Rating = 4, Review = "They wouldnt let me sing at the opera house, Must have been all the shrimp I ate off the barbie", Date = "03/08/2019"},
                    new Destination { DestinationId = 5, Country = "Canada", City = "Toronto", Rating = 3, Review = "Much to cold for my taste, But the Tim Hortens was fantastic", Date = "12/11/2018"}
                );
        }
    }
}