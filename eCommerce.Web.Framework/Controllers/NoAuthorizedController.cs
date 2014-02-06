using eCommerce.Data.UnitOfWork;

namespace eCommerce.Web.Framework.Controllers
{
   public class NoAuthorizedController: BaseController
    {
        protected readonly IUnitOfWork _uow;

        public NoAuthorizedController(IUnitOfWork uow)
            : base(uow)
        {
        }
    }
}
