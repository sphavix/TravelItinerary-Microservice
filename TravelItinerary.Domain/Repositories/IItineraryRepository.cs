

using System.ComponentModel.Design.Serialization;
using TravelItinerary.Domain.Entitties;

namespace TravelItinerary.Domain.Repositories
{
    public interface IItineraryRepository
    {
        Task<IEnumerable<Itinerary>> GetItinerariesAsync();
        Task<Itinerary> GetItineraryAsync(Guid id);
        Task<Itinerary> CreateItineraryAsync(Itinerary itinerary);
        Task<bool> UpdateItineraryAsync(Itinerary itinerary);
        Task<bool> DeleteItineraryAsync(Guid id);
    }
}