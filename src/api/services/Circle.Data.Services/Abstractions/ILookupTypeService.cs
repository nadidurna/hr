using Circle.Data.Requests.ManagementContracts;

namespace Circle.Data.Services.Abstractions
{
    public interface ILookupTypeService
    {
        Task<LookupTypeDto> GetLookupTypeById(Guid id, CancellationToken cancellationToken);
        Task<List<LookupTypeDto>> GetAll(CancellationToken cancellationToken);
        Task<bool> CreateLookupType(NewLookupTypeRequestDto data, CancellationToken cancellationToken);
        Task<bool> DeleteLookupTypeById(Guid id, CancellationToken cancellationToken);
        Task<bool> UpdateLookupType(UpdateLookupTypeRequestDto data, CancellationToken cancellationToken);
    }
}