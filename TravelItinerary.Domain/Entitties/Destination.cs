

namespace TravelItinerary.Domain.Entitties
{
    public class Destination
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Summary { get; set; }
        public List<Attraction> Attractions{ get; set; }
    }
}