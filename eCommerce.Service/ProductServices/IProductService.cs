using eCommerce.Core.Domain.DbEntities;

namespace eCommerce.Service.ProductServices
{
    public interface IProductService
    {
        /// <summary>
        /// Ürün ekle.
        /// </summary>
        /// <param name="product"></param>
        void Insert(Product product);
    }
}
