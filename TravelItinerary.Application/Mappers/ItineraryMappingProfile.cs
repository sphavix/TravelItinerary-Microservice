using AutoMapper;
using TravelItinerary.Application.CQRS.Attractions.Commands;
using TravelItinerary.Application.Responses;
using TravelItinerary.Domain.Entitties;

namespace TravelItinerary.Application.Mappers
{
    public class ItineraryMappingProfile : Profile
    {
        public ItineraryMappingProfile()
        {
            CreateMap<Attraction, AttractionResponse>().ReverseMap();
            CreateMap<Attraction, CreateAttractionCommand>().ReverseMap();
        }
    }
}