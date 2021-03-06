﻿using eCommerce.Core.Domain.DbEntities;
using eCommerce.Data.Repositories;
using eCommerce.Data.UnitOfWork;
using System.Linq;

namespace eCommerce.Service.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<Category> _categoryRepository;

        public CategoryService(IUnitOfWork uow)
        {
            _uow = uow;
            _categoryRepository = uow.GetRepository<Category>();
        }

        /// <summary>
        /// Tüm kategoriler.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        /// <summary>
        /// Kategori ekle.
        /// </summary>
        /// <param name="category"></param>
        public void Insert(Category category)
        {
            _categoryRepository.Insert(category);
        }
    }
}
