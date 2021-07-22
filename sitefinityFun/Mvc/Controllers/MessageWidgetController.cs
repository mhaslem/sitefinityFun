using sitefinityFun.Mvc.Models;
using System.ComponentModel;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace sitefinityFun.Mvc.Controllers
{
    // The ControllerToolboxItem attribute registers the widget in Sitefinity backend
    [ControllerToolboxItem(Name = "MessageWidget", Title = "Message Widget", SectionName = "MvcWidgets")]
    public class MessageWidgetController : Controller
    {
        /// <summary> 
        /// Gets or sets the message. 
        /// </summary>
        [Category("String Properties")]
        public string Message { get; set; }

        /// <summary> 
        /// This is the default Action. 
        /// </summary> 
        public ActionResult Index()
        {
            var model = new MessageWidgetModel();

            if (string.IsNullOrEmpty(this.Message))
            {
                model.Message = "Hello, Dude!";
            }
            else
            {
                model.Message = this.Message;
            }

            return View("Default", model);
        }
    }
}