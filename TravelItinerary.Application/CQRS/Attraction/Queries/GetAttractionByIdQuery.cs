
using MediatR;
using TravelItinerary.Application.Responses;

namespace TravelItinerary.Application.CQRS.Attraction.Queries
{
    public class GetAttractionByIdQuery : IRequest<AttractionResponse>
    {
        public Guid Id { get; set; }

        public GetAttractionByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}