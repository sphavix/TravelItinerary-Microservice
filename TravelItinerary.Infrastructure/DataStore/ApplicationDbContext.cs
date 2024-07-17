

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TravelItinerary.Domain.Entitties;

namespace TravelItinerary.Infrastructure.DataStore
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Itinerary> Itineraries { get; set; }
        public DbSet<Attraction> Attractions{ get; set; }
        public DbSet<Destination> Destinations { get; set; }
    }
}