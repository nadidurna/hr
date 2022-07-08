using AutoMapper;
using Circle.Data.Abstractions;
using Circle.Data.Requests.ManagementContracts;
using Circle.Data.Requests.Queries.ManagementQueries;
using Circle.Entities.Main;
using MediatR;

namespace Circle.Data.Management.Queries.ManagementQueries
{
    internal class GetLookupTypeByIdQuery : IRequestHandler<GetLookupTypeByIdRequest, LookupTypeDto>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetLookupTypeByIdQuery(IUnitOfWork unitOfWork,IMapper mapper )
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<LookupTypeDto> Handle(GetLookupTypeByIdRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<LookupType>();
            var entity = await repository.Get(x => !x.IsDeleted&&x.Id == request.Id, cancellationToken);
            if(entity is null)
            {
                return null;
            }
            var result = mapper.Map<LookupTypeDto>(entity);
            return result;
        }
    }
}