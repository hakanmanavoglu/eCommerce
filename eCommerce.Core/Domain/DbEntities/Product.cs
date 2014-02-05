namespace eCommerce.Core.Domain.DbEntities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string SeoName { get; set; }
        public string ProfileImgUrlOriginal { get; set; }
        public string ProfileImgUrlBig { get; set; }
        public string ProfileImgUrlMiddle { get; set; }
        public string ProfileImgUrlSmall { get; set; }
        public string SerialNo { get; set; }
        public int Quantity { get; set; }
        public string ShortDescription { get; set; }
        public string HtmlDescription { get; set; }
        public int ViewCount { get; set; }
        public int CommentCount { get; set; }
        public bool HasDiscount { get; set; }
        public float Rating { get; set; }
        public float Discount { get; set; }
        public float DiscountRate { get; set; }
        public float OldPrice { get; set; }
        public float NewPrice { get; set; }
        public string PriceCurrency { get; set; }

        public virtual Category Category { get; set; }
    }
}
