using AutoMapper;

namespace Circle.Data.Concretes
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext dbContext;
        private readonly IMapper mapper;

        public UnitOfWork(DbContext dbContext,IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public IRepository<T> GetRepository<T>() where T : EntityBase
        {
            return new Repository<T>(dbContext,mapper);
        }


        Task<int> IUnitOfWork.SaveChanges(CancellationToken cancellationToken)
        {
            return dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}