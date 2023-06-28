using DevFramework.Northwind.Business.Concrete.Managers;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace DevFramework.Northwind.Business.Test
{
    [TestClass]
    public class ProductManagerTests
    {
        [TestMethod]
        public void Fluent_validation_check()
        {

            try
            {
                Mock<IProductDal> mock = new Mock<IProductDal>();
                ProductManager productManager = new ProductManager(mock.Object);
                productManager.Add(new Product()
                {
                    ProductName = "Laptop",
                    CategoryId = 1,
                    QuantityPerUnit = "300",
                    UnitsInStock = 300,
                    UnitPrice = 3000
                });
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail("Fonksiyon bir istisna fırlattı: " + ex.Message);
            }
        }
    }
}
