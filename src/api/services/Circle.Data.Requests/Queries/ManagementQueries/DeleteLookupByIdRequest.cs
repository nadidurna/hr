using MediatR;

namespace Circle.Data.Requests.Queries.ManagementQueries
{
    public class DeleteLookupByIdRequest : IRequest<bool>
    {
        public DeleteLookupByIdRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}