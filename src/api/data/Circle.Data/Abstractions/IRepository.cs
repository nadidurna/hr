namespace Circle.Data.Abstractions
{
    public interface IRepository<T> where T : EntityBase
    {
        T Get(Guid id);

        T Get(Expression<Func<T, bool>> predicate);

        List<T> GetAll(Expression<Func<T, bool>> predicate);

        void Insert(T entity);

        void Update(T entity);

        void Delete(Guid id);

        void Delete(T entity);
    }
}