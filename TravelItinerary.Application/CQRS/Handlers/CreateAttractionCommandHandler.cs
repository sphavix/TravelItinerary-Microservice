using MediatR;
using TravelItinerary.Application.CQRS.Commands;
using TravelItinerary.Application.Mappers;
using TravelItinerary.Application.Responses;
using TravelItinerary.Domain.Entitties;
using TravelItinerary.Domain.Repositories;

namespace TravelItinerary.Application.CQRS.Attractions.Handlers
{
    public class CreateAttractionCommandHandler : IRequestHandler<CreateAttractionCommand, AttractionResponse>
    {
        private readonly IAttractionRepository _repository;
        public CreateAttractionCommandHandler(IAttractionRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<AttractionResponse> Handle(CreateAttractionCommand command, CancellationToken cancellationToken)
        {
            // Map command to the domain entity 
            var attraction = ItineraryMapper.Mapper.Map<Attraction>(command);

            if(attraction is null)
            {
                throw new ApplicationException("There was an issue with Mapping");
            }

            // add the mapped object to the database
            var newAttraction = await _repository.CreateAttractionAsync(attraction);

            // Map the response back to the domain entity
            var response = ItineraryMapper.Mapper.Map<AttractionResponse>(newAttraction);
            return response;
        }
    }
}