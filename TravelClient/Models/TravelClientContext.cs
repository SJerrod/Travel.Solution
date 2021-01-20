using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace TravelClient.Models
{
    public class TravelClientContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Destination> Destinations { get; set; }
        
        public TravelClientContext(DbContextOptions options) : base(options) { }
    }
}