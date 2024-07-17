namespace TravelItinerary.Application.Responses
{
    public class AttractionResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
         public string Summary { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Address { get; set; }
    }
}