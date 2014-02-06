using eCommerce.Data.UnitOfWork;
using System.Web.Mvc;

namespace eCommerce.Web.Framework.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : BaseController
    {
        public AdminController(IUnitOfWork uow)
            : base(uow)
        {
        }
    }
}
