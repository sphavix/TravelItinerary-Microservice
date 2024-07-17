using MediatR;
using TravelItinerary.Application.Responses;

namespace TravelItinerary.Application.CQRS.Queries
{
    public class GetAttractionsQuery : IRequest<IList<AttractionResponse>>
    {
        
    }
}