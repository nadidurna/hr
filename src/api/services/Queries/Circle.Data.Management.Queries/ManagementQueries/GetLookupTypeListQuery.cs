using Circle.Data.Abstractions;
using Circle.Data.Requests.ManagementContracts;
using Circle.Data.Requests.Queries.ManagementQueries;
using Circle.Entities.Main;
using MediatR;

namespace Circle.Data.Management.Queries.ManagementQueries
{
    internal class GetLookupTypeListQuery : IRequestHandler<GetLookupTypeListRequest, List<LookupTypeDto>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetLookupTypeListQuery(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public Task<List<LookupTypeDto>> Handle(GetLookupTypeListRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<LookupType>();
            return repository.GetAll<LookupTypeDto>(x => !x.IsDeleted, x => x.Name, cancellationToken);
        }
    }
}