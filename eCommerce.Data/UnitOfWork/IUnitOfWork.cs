using eCommerce.Data.Repositories;
using System;

namespace eCommerce.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        int SaveChanges();
    }
}
