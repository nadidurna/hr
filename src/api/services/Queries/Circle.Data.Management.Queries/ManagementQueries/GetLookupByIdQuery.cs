using AutoMapper;
using Circle.Data.Abstractions;
using Circle.Data.Requests.ManagementContracts;
using Circle.Data.Requests.Queries.ManagementQueries;
using Circle.Entities.Main;
using MediatR;

namespace Circle.Data.Management.Queries.ManagementQueries
{
    internal class GetLookupByIdQuery : IRequestHandler<GetLookupByIdRequest, LookupDto>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetLookupByIdQuery(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<LookupDto> Handle(GetLookupByIdRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<Lookup>();
            var result=  await repository.Get<LookupDto>(f => !f.IsDeleted && f.Id == request.Id, cancellationToken);
            return result;
        }
    }
}