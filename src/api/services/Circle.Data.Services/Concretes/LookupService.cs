using Circle.Data.Query.Requests;

namespace Circle.Data.Services.Concretes
{
    public class LookupService : ILookupService
    {
        private readonly IMediator mediator;

        public LookupService(IMediator mediator)
        {

            this.mediator = mediator;
        }

        public Task<List<Lookup>> GetLookups(CancellationToken cancellationToken)
        {
            return mediator.Send(new GetLookupRequest(), cancellationToken);
        }

    }        
}
