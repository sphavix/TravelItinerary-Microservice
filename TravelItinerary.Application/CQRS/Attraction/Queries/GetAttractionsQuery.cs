using MediatR;
using TravelItinerary.Application.Responses;

namespace TravelItinerary.Application.CQRS.Attraction.Queries
{
    public class GetAttractionsQuery : IRequest<IList<AttractionResponse>>
    {
        
    }
}