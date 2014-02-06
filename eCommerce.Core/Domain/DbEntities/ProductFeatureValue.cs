namespace eCommerce.Core.Domain.DbEntities
{
    public class ProductFeatureValue : BaseEntity
    {
        public string Value { get; set; }

        public virtual Product Product { get; set; }

        public virtual ProductFeature ProductFeature { get; set; }
    }
}
