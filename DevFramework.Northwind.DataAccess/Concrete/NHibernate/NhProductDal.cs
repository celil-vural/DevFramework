using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.ComplexTypes;
using DevFramework.Northwind.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        private NHibernateHelper _NHibernateHelper;
        public NhProductDal(NHibernateHelper helper) : base(helper)
        {
            _NHibernateHelper = helper;
        }

        public List<ProductDetail> GetProductDetails()
        {
            using (var session = _NHibernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                             join c in session.Query<Category>() on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 QuantityPerUnit = p.QuantityPerUnit,
                                 UnitPrice = p.UnitPrice,
                                 UnitsInStock = p.UnitsInStock,
                             };
                return result.ToList();
            }
        }
    }
}
