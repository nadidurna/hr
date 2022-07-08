using AutoMapper;
using Circle.Data.Abstractions;
using Circle.Data.Requests.Queries.ManagementQueries;
using Circle.Entities.Main;
using MediatR;

namespace Circle.Data.Managemet.Commands.ManagementCommand
{
    internal class DeleteLookupTypeCommand : IRequestHandler<DeleteLookupTypeByIdRequest, bool>
    {
        private readonly IUnitOfWork unitOfWork;
        public DeleteLookupTypeCommand(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(DeleteLookupTypeByIdRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<LookupType>();
            var entity = await repository.Get(x => !x.IsDeleted && x.Id == request.Id, cancellationToken);
            if(entity is null)
            {
                return false;
            }
            repository.Delete(entity);
            var result = await unitOfWork.SaveChanges(cancellationToken);
            return result > 0;
        }
    }
}