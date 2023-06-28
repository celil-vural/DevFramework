using DevFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings;
using DevFramework.Northwind.Entities.Concrete;
using System.Data.Entity;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);//veri tabanının kod tarafından üretilmesini engeller
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        /* public DbSet<Employees> Employees { get; set; }*/
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}
