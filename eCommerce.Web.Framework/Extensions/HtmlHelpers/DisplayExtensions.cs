using eCommerce.Web.Framework.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace eCommerce.Web.Framework.Extensions.HtmlHelpers
{
    public static class DisplayExtensions
    {
        public static MvcHtmlString DisplayMessage(this HtmlHelper htmlHelper)
        {
            var tempMessages = htmlHelper.ViewContext.TempData["MessagesForView"];
            if (tempMessages == null) return MvcHtmlString.Create(string.Empty);

            var messages = (List<MessageForView>)tempMessages;

            var messageToDisplay = "<ul class=\"msg\">";

            messageToDisplay = messages.Aggregate(messageToDisplay, (s, msg) =>
            {
                s += "<li class=\"msg-" + msg.MessageType.ToString() + "\">" + msg.Message + "</li>";
                return s;
            });

            messageToDisplay += "</ul>";

            return MvcHtmlString.Create(messageToDisplay);
        }
    }
}
