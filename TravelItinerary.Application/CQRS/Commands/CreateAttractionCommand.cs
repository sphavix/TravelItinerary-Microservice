using MediatR;
using TravelItinerary.Application.Responses;

namespace TravelItinerary.Application.CQRS.Commands
{
    public class CreateAttractionCommand : IRequest<AttractionResponse>
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Address { get; set; }
    }
}