
namespace TravelItinerary.Domain.Entitties
{
    public class Itinerary
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FlightNumber { get; set; }
        public string HotelAddress { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Destination> Destinations{ get; set; }
    }
}