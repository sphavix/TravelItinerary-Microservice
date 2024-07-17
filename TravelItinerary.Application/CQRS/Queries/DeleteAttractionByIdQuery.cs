
using MediatR;

namespace TravelItinerary.Application.CQRS.Queries
{
    public class DeleteAttractionByIdQuery : IRequest<bool>
    {
        public Guid Id { get; set; }

        public DeleteAttractionByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}