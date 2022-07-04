namespace Circle.Data.Concretes
{
    internal class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly DbContext dbContext;

        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            Update(entity);
        }

        public Task<T> Get(Guid id,CancellationToken cancellationToken)
        {
            return dbContext.Set<T>().SingleOrDefaultAsync(f => f.Id == id, cancellationToken);
        }

        public Task<T> Get(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            return dbContext.Set<T>().SingleOrDefaultAsync(predicate, cancellationToken);
        }

        public Task<List<T>> GetAll(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            return dbContext.Set<T>().Where(predicate).ToListAsync(cancellationToken);
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