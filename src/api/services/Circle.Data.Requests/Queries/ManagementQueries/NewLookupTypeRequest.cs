using MediatR;
using Circle.Data.Requests.ManagementContracts;

namespace Circle.Data.Requests.Queries.ManagementQueries
{
    public class NewLookupTypeRequest : IRequest<bool>
    {
        public NewLookupTypeRequest(NewLookupTypeRequestDto data)
        {
            Data = data;
        }
        public NewLookupTypeRequestDto Data { get; }
    }
}