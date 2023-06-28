using DevFramework.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace DevFramework.Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        Product Add(Product product);
        Product Update(Product product);
        Product Delete(Product product);
        void TransactionalOperation(Product product1, Product product2);
    }
}
