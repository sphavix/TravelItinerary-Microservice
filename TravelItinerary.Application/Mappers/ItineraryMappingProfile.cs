using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TravelItinerary.Application.Responses;
using TravelItinerary.Domain.Entitties;

namespace TravelItinerary.Application.Mappers
{
    public class ItineraryMappingProfile : Profile
    {
        public ItineraryMappingProfile()
        {
            CreateMap<Attraction, AttractionResponse>().ReverseMap();
        }
    }
}