using Circle.Data.Requests.ManagementContracts;
using Circle.Data.Requests.Queries.ManagementQueries;

namespace Circle.Data.Services.Concretes
{
    public class LookupTypeService : ILookupTypeService
    {
        private readonly IMediator mediator;

        public LookupTypeService(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public Task<bool> CreateLookupType(NewLookupTypeRequestDto data, CancellationToken cancellationToken)
        {
            return mediator.Send(new NewLookupTypeRequest(data), cancellationToken);
        }

        public Task<bool> DeleteLookupTypeById(Guid id, CancellationToken cancellationToken)
        {
            return mediator.Send(new DeleteLookupTypeByIdRequest(id), cancellationToken);
        }

        public Task<List<LookupTypeDto>> GetAll(CancellationToken cancellationToken)
        {
            return mediator.Send(new GetLookupTypeListRequest(), cancellationToken);
        }

        public Task<LookupTypeDto> GetLookupTypeById(Guid id, CancellationToken cancellationToken)
        {
            return mediator.Send(new GetLookupTypeByIdRequest(id), cancellationToken);
        }

        public Task<bool> UpdateLookupType(UpdateLookupTypeRequestDto data, CancellationToken cancellationToken)
        {
            return mediator.Send(new UpdateLookupTypeRequest(data), cancellationToken);
        }
    }
}