using DevFramework.Northwind.Entities.Abstract;

namespace DevFramework.Northwind.Entities.Concrete
{
    public class Category : IEntity
    {
        public virtual int CategoryId { get; set; }
        public virtual string CategoryName { get; set; }
        public virtual string Description { get; set; }
    }
}
