using System.Collections.Generic;
namespace eCommerce.Core.Domain.DbEntities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Children = new HashSet<Category>();
            Products = new HashSet<Product>();
        }

        public string Name { get; set; }
        public string SeoName { get; set; }
        public string ProfileImgUrl { get; set; }
        public int? ParentId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Category> Children { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
