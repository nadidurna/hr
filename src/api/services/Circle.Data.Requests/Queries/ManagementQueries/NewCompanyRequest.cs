using Circle.Data.Requests.ManagementContracts;
using MediatR;

namespace Circle.Data.Requests.Queries.ManagementQueries
{
    public class NewCompanyRequest : IRequest<bool>
    {
        public NewCompanyRequest(NewCompanyRequestDto data)
        {
            Data = data;
        }

        public NewCompanyRequestDto Data { get; }
    }
}