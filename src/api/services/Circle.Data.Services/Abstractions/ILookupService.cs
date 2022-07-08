using Circle.Data.Requests.ManagementContracts;

namespace Circle.Data.Services.Abstractions
{
    public interface ILookupService
    {
        Task<LookupDto> GetById(Guid id, CancellationToken cancellationToken);
        Task<List<LookupDto>> GetAll(CancellationToken cancellationToken);
        Task<bool> CreateLookup(NewLookupRequestDto data, CancellationToken cancellationToken);
        Task<bool> DeleteLookupById(Guid id, CancellationToken cancellationToken);
        Task<bool> UpdateLookup(UpdateLookupRequestDto data, CancellationToken cancellationToken);
    }
}