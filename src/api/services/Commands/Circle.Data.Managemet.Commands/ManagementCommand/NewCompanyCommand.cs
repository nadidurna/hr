using AutoMapper;
using Circle.Data.Abstractions;
using Circle.Data.Requests.Queries.ManagementQueries;
using Circle.Entities.Foundation;
using MediatR;

namespace Circle.Data.Managemet.Commands.ManagementCommand
{
    internal class NewCompanyCommand : IRequestHandler<NewCompanyRequest, bool>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public NewCompanyCommand(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<bool> Handle(NewCompanyRequest request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.Data.CompanyName))
            {
                return false;
            }
            var repository = unitOfWork.GetRepository<Company>();
            var conflict = await repository.Get(f => f.IsActive && !f.IsDeleted && f.CompanyName == request.Data.CompanyName, cancellationToken);
            if(conflict is not null)
            {
                return false;
            }
            var entity = mapper.Map<Company>(request.Data);
            repository.Insert(entity);
            var result = await unitOfWork.SaveChanges(cancellationToken);
            return result > 0;

        }
    }
}