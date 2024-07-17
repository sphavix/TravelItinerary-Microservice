
namespace TravelItinerary.Domain.Entitties
{
    public class Attraction
    {
        public Guid Id { get; set; }
        public string Titel { get; set; }
         public string Summary { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Address { get; set; }
    }
}