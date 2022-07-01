namespace Circle.Data.Concretes
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IRepository<T> GetRepository<T>() where T : EntityBase
        {
            return new Repository<T>(dbContext);
        }
        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }
    }
}