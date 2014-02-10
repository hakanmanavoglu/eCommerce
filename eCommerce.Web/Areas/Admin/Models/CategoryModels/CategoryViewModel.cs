using eCommerce.Core.Domain.DbEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace eCommerce.Web.Areas.Admin.Models.CategoryModels
{
    public class CategoryViewModel
    {
        [Required(ErrorMessage = "{0} alanı gereklidir!")]
        [Display(Name = "Kateogri Adı")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir!")]
        [Display(Name = "Resim")]
        public HttpPostedFileBase ProfileImgUrl { get; set; }

        [Display(Name = "Üst Kategori")]
        public int? ParentId { get; set; }

        [Display(Name = "Yayında?")]
        public bool IsActive { get; set; }

        public virtual IEnumerable<Category> Categories { get; set; }
    }
}