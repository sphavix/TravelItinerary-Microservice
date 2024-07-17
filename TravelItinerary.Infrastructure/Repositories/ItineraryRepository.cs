using Microsoft.EntityFrameworkCore;
using TravelItinerary.Domain.Entitties;
using TravelItinerary.Domain.Repositories;
using TravelItinerary.Infrastructure.DataStore;

namespace TravelItinerary.Infrastructure.Repositories
{
    public class ItineraryRepository : IItineraryRepository
    {
        private readonly ApplicationDbContext _context;

        public ItineraryRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Itinerary>> GetItinerariesAsync()
        {
            return await _context.Itineraries.ToListAsync();
        }

        public async Task<Itinerary> GetItineraryAsync(Guid id)
        {
            return await _context.Itineraries.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Itinerary> CreateItineraryAsync(Itinerary itinerary)
        {
            var result = _context.Itineraries.Add(itinerary);
            await _context.SaveChangesAsync().ConfigureAwait(true);
            return result.Entity;
        }

        public async Task<bool> UpdateItineraryAsync(Itinerary itinerary)
        {
            _context.Itineraries.Update(itinerary);
            return await _context.SaveChangesAsync().ConfigureAwait(true) > 0;
        }

        public async Task<bool> DeleteItineraryAsync(Guid id)
        {
            var itinerary = await _context.Itineraries.FindAsync(id).ConfigureAwait(true);
            _context.Itineraries.Remove(itinerary);
            return await _context.SaveChangesAsync().ConfigureAwait (true) > 0;
        }
    }
}