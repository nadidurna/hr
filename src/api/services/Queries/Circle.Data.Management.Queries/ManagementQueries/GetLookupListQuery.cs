using Circle.Data.Abstractions;
using Circle.Data.Requests.ManagementContracts;
using Circle.Data.Requests.Queries.ManagementQueries;
using Circle.Entities.Main;
using MediatR;

namespace Circle.Data.Management.Queries.ManagementQueries
{
    internal class GetLookupListQuery : IRequestHandler<LookupGetAllRequest, List<LookupDto>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetLookupListQuery(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public Task<List<LookupDto>> Handle(LookupGetAllRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<Lookup>();
            return repository.GetAll<LookupDto>(u => !u.IsDeleted, u => u.Name,cancellationToken);
        }
    }
}