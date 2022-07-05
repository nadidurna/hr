namespace Circle.Data.Abstractions
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<T> Get(Guid id,CancellationToken cancellationToken);

        Task<TDto> Get<TDto>(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

        Task<List<T>> GetAll(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}