using DevFramework.Core.DataAccess;
using DevFramework.Northwind.Entities.ComplexTypes;
using DevFramework.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace DevFramework.Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}
