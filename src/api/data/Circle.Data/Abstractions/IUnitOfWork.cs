namespace Circle.Data.Abstractions
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : EntityBase;

        Task<int> SaveChanges(CancellationToken cancellationToken);
    }
}