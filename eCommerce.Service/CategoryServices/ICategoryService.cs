using eCommerce.Core.Domain.DbEntities;
using System.Linq;
namespace eCommerce.Service.CategoryServices
{
    public interface ICategoryService
    {
        /// <summary>
        /// Tüm kategoriler.
        /// </summary>
        /// <returns></returns>
        IQueryable<Category> GetAll();
    }
}
