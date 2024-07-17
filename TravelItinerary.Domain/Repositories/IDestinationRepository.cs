using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelItinerary.Domain.Entitties;

namespace TravelItinerary.Domain.Repositories
{
    public interface IDestinationRepository
    {
        Task<IEnumerable<Destination>> GetDestinationsAsync();
        Task<Destination> GetDestinationAsync(Guid id);
        Task<Destination> CreateDestinationAsync(Destination itinerary);
        Task<bool> UpdateDestinationAsync(Destination itinerary);
        Task<bool> DeleteDestinationAsync(Guid id);
    }
}