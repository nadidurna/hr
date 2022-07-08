using Circle.Data.Requests.ManagementContracts;
using MediatR;

namespace Circle.Data.Requests.Queries.ManagementQueries
{
    public class GetLookupTypeListRequest : IRequest<List<LookupTypeDto>>
    {
    }
}