namespace Circle.Data.Concretes
{
    internal class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly DbContext dbContext;

        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Delete(Guid id)
        {
            var entity = Get(id);
            entity.IsDeleted = true;
            Update(entity);
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            Update(entity);
        }

        public T Get(Guid id)
        {
            return dbContext.Set<T>().SingleOrDefault(f => f.Id == id);
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return dbContext.Set<T>().SingleOrDefault(predicate);
        }

        public List<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return dbContext.Set<T>().Where(predicate).ToList();
        }

        public void Insert(T entity)
        {
            dbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            dbContext.Set<T>().Update(entity);
        }
    }
}