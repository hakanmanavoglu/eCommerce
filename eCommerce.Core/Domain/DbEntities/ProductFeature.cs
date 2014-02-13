using System.Collections.Generic;
namespace eCommerce.Core.Domain.DbEntities
{
    public class ProductFeature : BaseEntity
    {
        public ProductFeature()
        {
            ProductFeatureValues = new HashSet<ProductFeatureValue>();
            ProductFeatureOptions = new HashSet<ProductFeatureOption>();
        }

        public string Name { get; set; }

        public virtual ICollection<ProductFeatureValue> ProductFeatureValues { get; set; }
        public virtual ICollection<ProductFeatureOption> ProductFeatureOptions { get; set; }
    }
}
