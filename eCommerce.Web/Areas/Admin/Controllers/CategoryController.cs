using eCommerce.Core.Domain.DbEntities;
using eCommerce.Data.UnitOfWork;
using eCommerce.Service.CategoryServices;
using eCommerce.Utilities.StringManager;
using eCommerce.Web.Areas.Admin.Models.CategoryModels;
using eCommerce.Web.Framework.Controllers;
using System;
using System.IO;
using System.Web.Mvc;

namespace eCommerce.Web.Areas.Admin.Controllers
{
    public class CategoryController : NoAuthorizedController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(IUnitOfWork uow, ICategoryService categoryService)
            : base(uow)
        {
            _categoryService = categoryService;
        }

        public ActionResult AddCategory()
        {
            var model = new CategoryViewModel
            {
                Categories = _categoryService.GetAll()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult AddCategory(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var image = model.ProfileImgUrl;

                var category = new Category
                {
                    CreateDate = DateTime.Now,
                    Description = "Create category",
                    IsActive = model.IsActive,
                    Name = model.Name,
                    SeoName = StringOperations.ToSeoFriendlyString(model.Name),
                    UpdateDate = DateTime.Now,
                    ParentId = model.ParentId
                };

                if (image != null && image.ContentLength > 0)
                {
                    // resmin ismini değiştir.
                    var fileName = Guid.NewGuid().ToString() + System.IO.Path.GetExtension(image.FileName);

                    // dosya dizinlerinin yollarını oluştur.
                    var originalImageFolder = Server.MapPath("~/Content/Images/uploads/Category");

                    // dizin yoksa oluştur.
                    if (!Directory.Exists(originalImageFolder))
                    {
                        Directory.CreateDirectory(originalImageFolder);
                    }

                    // dosyayı kaydet
                    image.SaveAs(Path.Combine(originalImageFolder, fileName));

                    category.ProfileImgUrl = Path.Combine("Content/Images/uploads/Category/", fileName);
                }

                try
                {
                    _categoryService.Insert(category);
                    _uow.SaveChanges();
                    Success("Kategori kaydedildi.");
                }
                catch (Exception ex)
                {
                    model.Categories = _categoryService.GetAll();
                    Error("işlem başarısız! Açıklama: " + ex.Message);
                }
            }

            return View();
        }
    }
}