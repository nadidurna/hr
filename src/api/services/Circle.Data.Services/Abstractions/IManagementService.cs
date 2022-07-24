using Circle.Data.Requests.ManagementContracts;

namespace Circle.Data.Services.Abstractions
{
    public interface IManagementService
    {
        Task<List<CompanyDto>> GetAll(CancellationToken cancellationToken);
        Task<bool> AddCompany(NewCompanyRequestDto data, CancellationToken cancellationToken);
        Task<bool> DeleteCompany(Guid id, CancellationToken cancellationToken);
        Task<bool> UpdateCompany(UpdateCompanyRequestDto data, CancellationToken cancellationToken);
    }
}