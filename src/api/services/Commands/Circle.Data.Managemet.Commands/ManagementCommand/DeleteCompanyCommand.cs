using Circle.Data.Abstractions;
using Circle.Data.Requests.Queries.ManagementQueries;
using Circle.Entities.Foundation;
using MediatR;

namespace Circle.Data.Managemet.Commands.ManagementCommand
{
    internal class DeleteCompanyCommand : IRequestHandler<DeleteCompanyRequest, bool>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteCompanyCommand(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(DeleteCompanyRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<Company>();
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