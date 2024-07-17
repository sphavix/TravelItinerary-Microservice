using Microsoft.EntityFrameworkCore;
using TravelItinerary.Domain.Entitties;
using TravelItinerary.Domain.Repositories;
using TravelItinerary.Infrastructure.DataStore;

namespace TravelItinerary.Infrastructure.Repositories
{
    public class DestinationRepository : IDestinationRepository
    {
        private readonly ApplicationDbContext _context;

        public DestinationRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Destination>> GetDestinationsAsync()
        {
            return await _context.Destinations.ToListAsync();
        }

        public async Task<Destination> GetDestinationAsync(Guid id)
        {
            return await _context.Destinations.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Destination> CreateDestinationAsync(Destination destination)
        {
            var result = _context.Destinations.Add(destination);
            await _context.SaveChangesAsync().ConfigureAwait(true);
            return result.Entity;
        }

        public async Task<bool> UpdateDestinationAsync(Destination destination)
        {
            _context.Destinations.Update(destination);
            return await _context.SaveChangesAsync().ConfigureAwait(true) > 0;
        }

        public async Task<bool> DeleteDestinationAsync(Guid id)
        {
            var destination = await _context.Destinations.FindAsync(id).ConfigureAwait(true);
            _context.Destinations.Remove(destination);
            return await _context.SaveChangesAsync().ConfigureAwait (true) > 0;
        }
    }
}