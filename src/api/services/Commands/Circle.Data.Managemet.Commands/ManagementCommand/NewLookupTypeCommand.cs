using AutoMapper;
using Circle.Data.Abstractions;
using Circle.Data.Requests.Queries.ManagementQueries;
using Circle.Entities.Main;
using MediatR;

namespace Circle.Data.Managemet.Commands.ManagementCommand
{
    internal class NewLookupTypeCommand : IRequestHandler<NewLookupTypeRequest, bool>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public NewLookupTypeCommand(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<bool> Handle(NewLookupTypeRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<LookupType>();
            var conflict = await repository.Get(x => x.IsActive && !x.IsDeleted && x.Name == request.Data.Name, cancellationToken);
            if(conflict is not null)
            {
                return false;
            }
            var entity = mapper.Map<LookupType>(request.Data);
            repository.Insert(entity);
            var result = await unitOfWork.SaveChanges(cancellationToken);
            return result > 0;
        }
    }
}