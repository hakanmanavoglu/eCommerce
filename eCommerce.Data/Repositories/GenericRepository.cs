﻿using eCommerce.Data.Context;
using System.Data.Entity;
using System.Linq;

namespace eCommerce.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly eCommerceContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(eCommerceContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        /// <summary>
        /// Tüm kayıtlar.
        /// </summary>
        /// <returns></returns>
        public virtual IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        /// <summary>
        /// Kayıt bul.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual TEntity Find(int id)
        {
            return _dbSet.Find(id);
        }

        /// <summary>
        /// Kayıt ekle.
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        /// <summary>
        /// Kayıt güncelle.
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Kayıt sil.
        /// </summary>
        /// <param name="id">Kayıt id</param>
        public virtual void Delete(int id)
        {
            TEntity entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }

        /// <summary>
        /// Kayıt sil.
        /// </summary>
        /// <param name="entity">Kayıt</param>
        public virtual void Delete(TEntity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }
    }
}
