using Circle.Data.Requests.ManagementContracts;
using MediatR;

namespace Circle.Data.Requests.Queries.ManagementQueries
{
    public class GetLookupByIdRequest : IRequest<LookupDto>
    {
        public GetLookupByIdRequest(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; }
    }
}