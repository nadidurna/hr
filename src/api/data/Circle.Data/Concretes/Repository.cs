using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace Circle.Data.Concretes
{
    internal class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly DbContext dbContext;
        private readonly IMapper mapper;
        private readonly IClaims claims;

        public Repository(DbContext dbContext, IMapper mapper, IClaims claims)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.claims = claims;
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

        public Task<List<TDto>> GetAll<TDto>(Expression<Func<T, bool>> predicate,Expression<Func<TDto,object>>order, CancellationToken cancellationToken)
        {
            return dbContext.Set<T>().Where(predicate).ProjectTo<TDto>(mapper.ConfigurationProvider).OrderBy(order).ToListAsync(cancellationToken);
        }

        public void Insert(T entity)
        {


            if (claims.IsAuthenticated)
            {
                entity.CreatedBy = claims.CurrentUser.Id;
                entity.ModifiedBy = claims.CurrentUser.Id;
            }
            entity.IsDeleted = false;
            entity.IsActive = true;
            entity.CreatedAt = DateTime.Now;
            entity.ModifiedAt = DateTime.Now;
            dbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            if (claims.IsAuthenticated)
            {
                entity.ModifiedBy = claims.CurrentUser.Id;
            }
            entity.ModifiedAt = DateTime.Now;
            dbContext.Set<T>().Update(entity);
        }
    }
}