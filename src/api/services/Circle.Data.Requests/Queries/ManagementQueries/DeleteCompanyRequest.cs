using MediatR;

namespace Circle.Data.Requests.Queries.ManagementQueries
{
    public class DeleteCompanyRequest : IRequest<bool>
    {
        public DeleteCompanyRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}