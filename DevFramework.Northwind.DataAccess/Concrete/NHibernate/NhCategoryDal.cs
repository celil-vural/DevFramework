using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concrete;

namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate
{
    internal class NhCategoryDal : NhEntityRepositoryBase<Category>, ICategoryDal
    {
        public NhCategoryDal(NHibernateHelper helper) : base(helper)
        {
        }
    }
}
