using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace Circle.Data.Concretes
{
    internal class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly DbContext dbContext;
        private readonly IMapper mapper;

        public Repository(DbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
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

        public Task<TDto> Get<TDto>(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            return dbContext.Set<T>().Where(predicate).ProjectTo<TDto>(mapper.ConfigurationProvider).SingleOrDefaultAsync(cancellationToken);
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