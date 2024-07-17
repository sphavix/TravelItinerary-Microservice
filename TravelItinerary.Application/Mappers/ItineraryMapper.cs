
using AutoMapper;

namespace TravelItinerary.Application.Mappers
{
    public static class ItineraryMapper
    {
        private static readonly Lazy<IMapper> LazyMapper = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<ItineraryMappingProfile>();
            });

            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => LazyMapper.Value;
    }
}