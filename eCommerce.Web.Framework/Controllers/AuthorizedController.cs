using eCommerce.Data.UnitOfWork;
using System.Web.Mvc;
namespace eCommerce.Web.Framework.Controllers
{
    [Authorize]
    public class AuthorizedController : BaseController
    {
        protected readonly IUnitOfWork _uow;

        public AuthorizedController(IUnitOfWork uow)
            : base(uow)
        {
        }
    }
}
