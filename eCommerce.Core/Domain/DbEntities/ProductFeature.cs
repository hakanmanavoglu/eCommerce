using System.Collections.Generic;
namespace eCommerce.Core.Domain.DbEntities
{
    public class ProductFeature : BaseEntity
    {
        public ProductFeature()
        {
            ProductFeatureValues = new HashSet<ProductFeatureValue>();
        }

        public string Name { get; set; }

        public virtual ICollection<ProductFeatureValue> ProductFeatureValues { get; set; }
    }
}
