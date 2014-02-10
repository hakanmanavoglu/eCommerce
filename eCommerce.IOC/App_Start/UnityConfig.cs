using eCommerce.Core.Domain.DbEntities;
using eCommerce.Data.Repositories;
using eCommerce.Data.UnitOfWork;
using eCommerce.Service.CategoryServices;
using eCommerce.Service.ProductServices;
using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Unity.Mvc5;

namespace eCommerce.IOC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            RegisterTypes(container);

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.BindInRequestScope<IGenericRepository<User>, GenericRepository<User>>();
            container.BindInRequestScope<IGenericRepository<Role>, GenericRepository<Role>>();

            container.BindInRequestScope<IUnitOfWork, UnitOfWork>();

            //container.BindInRequestScope<IUserService, UserService>();
            //container.BindInRequestScope<IRoleService, RoleService>();
            container.BindInRequestScope<ICategoryService, CategoryService>();
            container.BindInRequestScope<IProductService, ProductService>();
        }
    }

    /// <summary>
    /// Bind the given interface in request scope
    /// </summary>
    public static class IOCExtensions
    {
        public static void BindInRequestScope<T1, T2>(this IUnityContainer container) where T2 : T1
        {
            container.RegisterType<T1, T2>(new HierarchicalLifetimeManager());
        }

        public static void BindInSingletonScope<T1, T2>(this IUnityContainer container) where T2 : T1
        {
            container.RegisterType<T1, T2>(new ContainerControlledLifetimeManager());
        }
    }
}