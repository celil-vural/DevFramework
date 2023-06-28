using DevFramework.Core.DataAccess;
using DevFramework.Northwind.Entities.Concrete;

namespace DevFramework.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
