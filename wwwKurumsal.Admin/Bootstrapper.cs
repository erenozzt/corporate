using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using wwwKurumsal.Core.Interfaces;
using wwwKurumsal.Core.Repositories;

namespace wwwKurumsal.Admin
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
             
            container.RegisterType<IUsersRepository, UsersRepository>();
            container.RegisterType<IFixedPagesRepository, FixedPagesRepository>(); 
            container.RegisterType<IProductsRepository, ProductsRepository>(); 
            container.RegisterType<ICategoriesRepository, CategoriesRepository>();
            container.RegisterType<ISettingsRepository, SettingsRepository>();

            return container;
        }
    }
}