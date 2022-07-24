using Circle.Data.Abstractions;
using Circle.Data.Requests.ManagementContracts;
using Circle.Data.Requests.Queries.ManagementQueries;
using Circle.Entities.Foundation;
using MediatR;

namespace Circle.Data.Management.Queries.ManagementQueries
{
    internal class GetCompanyListQuery : IRequestHandler<CompanyGetAllRequest, List<CompanyDto>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetCompanyListQuery(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public Task<List<CompanyDto>> Handle(CompanyGetAllRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<Company>();
            return repository.GetAll<CompanyDto>(c => !c.IsDeleted, c => c.CompanyName, cancellationToken);
        }
    }
}