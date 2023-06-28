using DevFramework.Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private NHibernateHelper _helper;

        public NhEntityRepositoryBase(NHibernateHelper helper)
        {
            _helper = helper;
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var session = _helper.OpenSession())
            {
                return filter == null ? session.Query<TEntity>().ToList() : session.Query<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var session = _helper.OpenSession())
            {
                return session.Query<TEntity>().SingleOrDefault(filter);
            }
        }

        public TEntity Add(TEntity entity)
        {
            using (var session = _helper.OpenSession())
            {
                session.Save(entity);
                return entity;
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var session = _helper.OpenSession())
            {
                session.Update(entity);
                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using (var session = _helper.OpenSession())
            {
                session.Delete(entity);
            }
        }
    }
}
