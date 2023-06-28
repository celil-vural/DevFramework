using DevFramework.Northwind.Entities.Abstract;
using System.Linq;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private readonly NHibernateHelper _nHibernateHelper;
        private IQueryable<T> _entities;
        public NhQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public IQueryable<T> Table => this.Entities;

        public virtual IQueryable<T> Entities => _entities ?? (_entities = _nHibernateHelper.OpenSession().Query<T>());
    }
}
