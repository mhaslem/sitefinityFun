using sitefinityFun.Mvc.Models;
using System.ComponentModel;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace sitefinityFun.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "MessageFormWidget", Title = "Message Form Widget", SectionName = "MvcWidgets")]
    public class MessageFormController : Controller
    {
        [Category("String Properties")]
        public string Message { get; set; }

        public ActionResult Index()
        {
            var model = new MessageFormModel();

            this.Message = "Yo, what's up?";

            return View("Default", model);
        }
    }
} 