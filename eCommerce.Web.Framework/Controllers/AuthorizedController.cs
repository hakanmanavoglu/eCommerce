﻿using eCommerce.Data.UnitOfWork;
using System.Web.Mvc;
namespace eCommerce.Web.Framework.Controllers
{
    [Authorize]
    public class AuthorizedController : BaseController
    {
        public AuthorizedController(IUnitOfWork uow)
            : base(uow)
        {
        }
    }
}
