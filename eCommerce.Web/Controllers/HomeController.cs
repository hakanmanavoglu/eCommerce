using eCommerce.Data.UnitOfWork;
using eCommerce.Web.Framework.Controllers;
using System.Web.Mvc;

namespace eCommerce.Web.Controllers
{
    public partial class HomeController : NoAuthorizedController
    {
        public HomeController(IUnitOfWork uow)
            : base(uow)
        {
        }

        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}