using DevFramework.Northwind.Entities.Abstract;
using System.Data.Entity;
using System.Linq;

namespace DevFramework.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private readonly DbContext _dbContext;
        private IDbSet<T> _entities;
        public EfQueryableRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Table => this._entities;

        protected virtual IDbSet<T> Entities => _entities ?? (_entities = _dbContext.Set<T>());
    }
}
