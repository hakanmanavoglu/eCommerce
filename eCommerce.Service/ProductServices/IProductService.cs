﻿using eCommerce.Core.Domain.DbEntities;
using System.Linq;

namespace eCommerce.Service.ProductServices
{
    public interface IProductService
    {
        /// <summary>
        /// Ürün ekle.
        /// </summary>
        /// <param name="product"></param>
        void Insert(Product product);

        /// <summary>
        /// Tüm ürünler.
        /// </summary>
        /// <returns></returns>
        IQueryable<Product> GetAll();

        /// <summary>
        /// Ürün bul.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Product Find(int id);
    }
}
