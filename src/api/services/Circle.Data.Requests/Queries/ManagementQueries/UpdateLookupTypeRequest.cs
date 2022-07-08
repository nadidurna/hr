using Circle.Data.Requests.ManagementContracts;
using MediatR;

namespace Circle.Data.Requests.Queries.ManagementQueries
{
    public class UpdateLookupTypeRequest : IRequest<bool>
    {
        public UpdateLookupTypeRequest(UpdateLookupTypeRequestDto data)
        {
            Data = data;
        }

        public UpdateLookupTypeRequestDto Data { get; }
    }
}