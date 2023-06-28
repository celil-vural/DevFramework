using Ninject;

namespace DevFramework.Northwind.Business.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule(), new ValidationModule());
            return kernel.Get<T>();
        }
    }
}
