using MediatR;

namespace Circle.Data.Requests.Queries.ManagementQueries
{
    public class DeleteLookupTypeByIdRequest : IRequest<bool>
    {
        public DeleteLookupTypeByIdRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}