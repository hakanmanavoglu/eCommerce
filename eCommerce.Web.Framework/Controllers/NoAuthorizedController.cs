using eCommerce.Data.UnitOfWork;

namespace eCommerce.Web.Framework.Controllers
{
   public class NoAuthorizedController: BaseController
    {
        public NoAuthorizedController(IUnitOfWork uow)
            : base(uow)
        {
        }
    }
}
