using Circle.Data.Requests.ManagementContracts;
using Circle.Data.Requests.Queries.ManagementQueries;

namespace Circle.Data.Services.Concretes
{
    internal class ManagementService : IManagementService
    {
        private readonly IMediator mediator;

        public ManagementService(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public Task<bool> AddCompany(NewCompanyRequestDto data, CancellationToken cancellationToken)
        {
            return mediator.Send(new NewCompanyRequest(data), cancellationToken);
        }

        public Task<bool> DeleteCompany(Guid id, CancellationToken cancellationToken)
        {
            return mediator.Send(new DeleteCompanyRequest(id), cancellationToken);
        }

        public Task<List<CompanyDto>> GetAll(CancellationToken cancellationToken)
        {
            return mediator.Send(new CompanyGetAllRequest(), cancellationToken);
        }

        public Task<bool> UpdateCompany(UpdateCompanyRequestDto data, CancellationToken cancellationToken)
        {
            return mediator.Send(new CompanyUpdateRequest(data), cancellationToken);
        }
    }
}