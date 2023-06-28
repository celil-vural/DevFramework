using DevFramework.Northwind.Entities.Abstract;
using System.Linq;

namespace DevFramework.Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
