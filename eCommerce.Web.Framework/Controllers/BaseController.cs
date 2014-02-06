using eCommerce.Data.UnitOfWork;
using eCommerce.Web.Framework.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace eCommerce.Web.Framework.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IUnitOfWork _uow;

        public BaseController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        #region messages for view
        public void Default(string message)
        {
            AddMessage(message, MessageTypes.Default);
        }

        public void Info(string message)
        {
            AddMessage(message, MessageTypes.Info);
        }

        public void Success(string message)
        {
            AddMessage(message, MessageTypes.Success);
        }

        public void Warning(string message)
        {
            AddMessage(message, MessageTypes.Warning);
        }

        public void Error(string message)
        {
            AddMessage(message, MessageTypes.Error);
        }
        #endregion

        #region private methods
        private void AddMessage(string message, MessageTypes type)
        {
            var messages = new List<MessageForView>();

            if (TempData["MessagesForView"] != null)
                messages = (List<MessageForView>)TempData["MessagesForView"];

            messages.Add(new MessageForView { MessageType = type, Message = message });

            TempData["MessagesForView"] = messages;
        }
        #endregion
    }
}
