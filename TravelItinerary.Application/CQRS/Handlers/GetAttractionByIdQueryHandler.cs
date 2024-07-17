
using MediatR;
using TravelItinerary.Application.CQRS.Queries;
using TravelItinerary.Application.Mappers;
using TravelItinerary.Application.Responses;
using TravelItinerary.Domain.Repositories;

namespace TravelItinerary.Application.CQRS.Handlers
{
    public class GetAttractionByIdQueryHandler : IRequestHandler<GetAttractionByIdQuery, AttractionResponse>
    {
        private readonly IAttractionRepository _repository;
        public GetAttractionByIdQueryHandler(IAttractionRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<AttractionResponse> Handle(GetAttractionByIdQuery query, CancellationToken cancellationToken)
        {
            var attraction = await _repository.GetAttractionAsync(query.Id);
            var attractionResponse = ItineraryMapper.Mapper.Map<AttractionResponse>(attraction);
            return attractionResponse;
        }
    }
}