using eCommerce.Core.Domain.DbEntities;
using eCommerce.Data.Repositories;
using eCommerce.Data.UnitOfWork;
using System.Linq;

namespace eCommerce.Service.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<Product> _productRepository;

        public ProductService(IUnitOfWork uow)
        {
            _uow = uow;
            _productRepository = uow.GetRepository<Product>();
        }

        /// <summary>
        /// Ürün ekle.
        /// </summary>
        /// <param name="product"></param>
        public void Insert(Product product)
        {
            _productRepository.Insert(product);
        }

        /// <summary>
        /// Tüm ürünler.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        /// <summary>
        /// Ürün bul.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product Find(int id)
        {
            return _productRepository.Find(id);
        }
    }
}
