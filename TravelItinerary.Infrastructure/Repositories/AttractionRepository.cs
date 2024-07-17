using Microsoft.EntityFrameworkCore;
using TravelItinerary.Domain.Entitties;
using TravelItinerary.Domain.Repositories;
using TravelItinerary.Infrastructure.DataStore;

namespace TravelItinerary.Infrastructure.Repositories
{
    public class AttractionRepository : IAttractionRepository
    {
        private readonly ApplicationDbContext _context;

        public AttractionRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Attraction>> GetAttractionsAsync()
        {
            return await _context.Attractions.ToListAsync();
        }

        public async Task<Attraction> GetAttractionAsync(Guid id)
        {
            return await _context.Attractions.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Attraction> CreateAttractionAsync(Attraction attraction)
        {
            var result = _context.Attractions.Add(attraction);
            await _context.SaveChangesAsync().ConfigureAwait(true);
            return result.Entity;
        }

        public async Task<bool> UpdateAttractionAsync(Attraction attraction)
        {
            _context.Attractions.Update(attraction);
            return await _context.SaveChangesAsync().ConfigureAwait(true) > 0;
        }

        public async Task<bool> DeleteAttractionAsync(Guid id)
        {
            var attraction = await _context.Attractions.FindAsync(id).ConfigureAwait(true);
            _context.Attractions.Remove(attraction);
            return await _context.SaveChangesAsync().ConfigureAwait (true) > 0;
        }
    }
}