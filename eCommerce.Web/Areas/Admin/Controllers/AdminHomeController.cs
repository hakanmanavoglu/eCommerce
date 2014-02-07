using eCommerce.Data.UnitOfWork;
using eCommerce.Web.Framework.Controllers;
using System.Web.Mvc;

namespace eCommerce.Web.Areas.Admin.Controllers
{
    public class AdminHomeController : NoAuthorizedController
    {
        public AdminHomeController(IUnitOfWork uow)
            : base(uow)
        {

        }

        public ActionResult Index()
        {
            return View();
        }
    }
}