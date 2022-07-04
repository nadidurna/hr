namespace Circle.Data.Services.Abstractions
{
    public interface ILookupService
    {
        Task<List<Lookup>> GetLookups(CancellationToken cancellationToken);
    }
}