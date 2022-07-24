using Circle.Data.Requests.ManagementContracts;
using MediatR;

namespace Circle.Data.Requests.Queries.ManagementQueries
{
    public class CompanyUpdateRequest : IRequest<bool>
    {
        public CompanyUpdateRequest(UpdateCompanyRequestDto data)
        {
            Data = data;
        }

        public UpdateCompanyRequestDto Data { get; }
    }
}