

using TravelItinerary.Domain.Entitties;

namespace TravelItinerary.Domain.Repositories
{
    public interface IAttractionRepository
    {
        Task<IEnumerable<Attraction>> GetAttractionsAsync();
        Task<Attraction> GetAttractionAsync(Guid id);
        Task<Attraction> CreateAttractionAsync(Attraction itinerary);
        Task<bool> UpdateAttractionAsync(Attraction itinerary);
        Task<bool> DeleteAttractionAsync(Guid id);
    }
}