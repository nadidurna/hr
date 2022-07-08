using Circle.Data.Requests.ManagementContracts;
using MediatR;

namespace Circle.Data.Requests.Queries.ManagementQueries
{
    public class NewLookupRequest : IRequest<bool>
    {
        public NewLookupRequest(NewLookupRequestDto data)
        {
            Data = data;
        }

        public NewLookupRequestDto Data { get; }
    }
}