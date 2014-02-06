using eCommerce.Core.Domain.DbEntities;
using eCommerce.Data.UnitOfWork;
using eCommerce.Service.UserServices;
using eCommerce.Web.Framework.Controllers;
using eCommerce.Web.Models.AccountModels;
using System;
using System.Web.Mvc;

namespace eCommerce.Web.Controllers
{
    public class AccountController : NoAuthorizedController
    {
        private readonly IUserService _userService;

        public AccountController(IUnitOfWork uow, IUserService userService)
            : base(uow)
        {
            _userService = userService;
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    User user = new User
                    {
                        ConfirmationId = Guid.NewGuid(),
                        IsConfirmed = true,
                        LastLoginDate = DateTime.Now,
                        LastLoginIp = Request.UserHostAddress,
                        Password = model.Password,
                        ProfileImgUrl = "Content/Images/no_profile_image.png",
                        Email = model.Email,
                        UserName = model.UserName,
                        IsActive = true,
                    };

                    _userService.Insert(user);
                    _userService.SendConfirmationMail(user, Request.Url.GetLeftPart(UriPartial.Authority));
                    _uow.SaveChanges();

                    return RedirectToAction("Index", "Home");
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Kullanıcı oluşturma başarısız!");
                }
            }

            return View(model);
        }
    }
}