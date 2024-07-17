using MediatR;
using TravelItinerary.Application.CQRS.Queries;
using TravelItinerary.Domain.Repositories;

namespace TravelItinerary.Application.CQRS.Handlers
{
    public class DeleteAttractionByIdQueryHandler : IRequestHandler<DeleteAttractionByIdQuery, bool>
    {
        private readonly IAttractionRepository _repository;
        public DeleteAttractionByIdQueryHandler(IAttractionRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<bool> Handle(DeleteAttractionByIdQuery query, CancellationToken cancellationToken)
        {
            return await _repository.DeleteAttractionAsync(query.Id);
        }
    }
}