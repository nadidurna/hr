using Circle.Data.Requests.ManagementContracts;
using MediatR;

namespace Circle.Data.Requests.Queries.ManagementQueries
{
    public class GetLookupTypeByIdRequest : IRequest<LookupTypeDto>
    {
        public GetLookupTypeByIdRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}