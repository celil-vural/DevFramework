using DevFramework.Northwind.Entities.Abstract;

namespace DevFramework.Northwind.Entities.Concrete
{
    public class Product : IEntity
    {
        public virtual int ProductId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual string QuantityPerUnit { get; set; }
        public virtual short UnitsInStock { get; set; }

    }
}
