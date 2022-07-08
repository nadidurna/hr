using AutoMapper;
using Circle.Data.Abstractions;
using Circle.Data.Requests.Queries.ManagementQueries;
using Circle.Entities.Main;
using MediatR;

namespace Circle.Data.Managemet.Commands.ManagementCommand
{
    internal class UpdateLookupTypeCommand : IRequestHandler<UpdateLookupTypeRequest, bool>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UpdateLookupTypeCommand(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<bool> Handle(UpdateLookupTypeRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<LookupType>();
            var entity = await repository.Get(x => x.Id == request.Data.Id, cancellationToken);
            if(entity is null)
            {
                return false;
            }
            var mapped = mapper.Map(request.Data, entity);
            repository.Update(mapped);
            var result = await unitOfWork.SaveChanges(cancellationToken);
            return result > 0;
        }
    }
}