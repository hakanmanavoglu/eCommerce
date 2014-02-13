namespace eCommerce.Core.Domain.DbEntities
{
    public class ProductFeatureOption : BaseEntity
    {
        public string Name { get; set; }
        public int ProductFeatureId { get; set; }

        public virtual ProductFeature ProductFeature { get; set; }
    }
}
