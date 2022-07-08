using Circle.Data.Requests.ManagementContracts;
using MediatR;

namespace Circle.Data.Requests.Queries.ManagementQueries
{
    public class UpdateLookupRequest : IRequest<bool>
    {
        public UpdateLookupRequest(UpdateLookupRequestDto data)
        {
            Data = data;
        }

        public UpdateLookupRequestDto Data { get; }
    }
}