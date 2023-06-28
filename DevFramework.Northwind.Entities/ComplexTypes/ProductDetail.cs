namespace DevFramework.Northwind.Entities.ComplexTypes
{
    public class ProductDetail
    {
        public virtual int ProductId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string CategoryName { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual string QuantityPerUnit { get; set; }
        public virtual short UnitsInStock { get; set; }
    }
}
