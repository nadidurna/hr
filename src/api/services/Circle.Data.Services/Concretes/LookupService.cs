using Circle.Data.Requests.ManagementContracts;
using Circle.Data.Requests.Queries.ManagementQueries;

namespace Circle.Data.Services.Concretes
{
    public class LookupService : ILookupService
    {
        private readonly IMediator mediator;

        public LookupService(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public Task<bool> CreateLookup(NewLookupRequestDto data, CancellationToken cancellationToken)
        {
            return mediator.Send(new NewLookupRequest(data), cancellationToken);
        }

        public Task<bool> DeleteLookupById(Guid id, CancellationToken cancellationToken)
        {
            return mediator.Send(new DeleteLookupByIdRequest(id), cancellationToken);
        }

        public Task<List<LookupDto>> GetAll(CancellationToken cancellationToken)
        {
            return mediator.Send(new LookupGetAllRequest(), cancellationToken);
        }

        public Task<LookupDto> GetById(Guid id, CancellationToken cancellationToken)
        {
            return mediator.Send(new GetLookupByIdRequest(id), cancellationToken);
        }

        public Task<bool> UpdateLookup(UpdateLookupRequestDto data, CancellationToken cancellationToken)
        {
            return mediator.Send(new UpdateLookupRequest(data), cancellationToken);
        }
    }
}