using eCommerce.Core.Domain.DbEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace eCommerce.Web.Areas.Admin.Models.ProductModels
{
    public class ProductViewModel
    {
        [Required(ErrorMessage = "{0} alanı gereklidir!")]
        [Display(Name = "Ürün Adı")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir!")]
        [Display(Name = "Ürün Resim")]
        public HttpPostedFileBase ProfileImgUrlOriginal { get; set; }

        [Display(Name = "Seri No")]
        public string SerialNo { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir!")]
        [Display(Name = "Adet")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir!")]
        [Display(Name = "Kısa Açıklama")]
        public string ShortDescription { get; set; }

        [Display(Name = "Detaylı Açıklama")]
        public string HtmlDescription { get; set; }

        [Display(Name = "İndirimli?")]
        public bool HasDiscount { get; set; }

        [Display(Name = "İndirim Tutar")]
        public float Discount { get; set; }

        [Display(Name = "İndirim Yüzde")]
        public float DiscountRate { get; set; }

        [Display(Name = "Eski Fiyat")]
        public float OldPrice { get; set; }

        [Display(Name = "Yeni Fiyat")]
        public float NewPrice { get; set; }

        [Display(Name = "Para Birimi")]
        public string PriceCurrency { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir!")]
        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }

        [Display(Name = "Yayında?")]
        public bool IsActive { get; set; }

        public virtual IEnumerable<Category> Categories { get; set; }
    }
}