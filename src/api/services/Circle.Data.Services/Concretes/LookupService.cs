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

        public Task<LookupDto> GetById(Guid id, CancellationToken cancellationToken)
        {
            return mediator.Send(new GetLookupByIdRequest(id), cancellationToken);
        }
    }
}