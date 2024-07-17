
using MediatR;
using TravelItinerary.Application.CQRS.Queries;
using TravelItinerary.Application.Mappers;
using TravelItinerary.Application.Responses;
using TravelItinerary.Domain.Repositories;

namespace TravelItinerary.Application.CQRS.Handlers
{
    public class GetAttractionsQueryHandler : IRequestHandler<GetAttractionsQuery, IList<AttractionResponse>>
    {
        private readonly IAttractionRepository _repository;
        public GetAttractionsQueryHandler(IAttractionRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<IList<AttractionResponse>> Handle(GetAttractionsQuery query, CancellationToken cancellationToken) //Will implement cancellation token later
        {
            var attractions = await _repository.GetAttractionsAsync();

            // Map the Attraction Entity to the AttractionResponse object
            var attractionResponse = ItineraryMapper.Mapper.Map<IList<AttractionResponse>>(attractions);
            return attractionResponse;
        }
    }
}