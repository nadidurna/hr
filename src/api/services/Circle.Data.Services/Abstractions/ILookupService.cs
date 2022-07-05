using Circle.Data.Requests.ManagementContracts;

namespace Circle.Data.Services.Abstractions
{
    public interface ILookupService
    {
        Task<LookupDto> GetById(Guid id, CancellationToken cancellationToken);
    }
}