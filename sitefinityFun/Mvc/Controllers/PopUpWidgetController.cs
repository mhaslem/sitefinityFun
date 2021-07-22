using sitefinityFun.Mvc.Models;
using System.ComponentModel;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace sitefinityFun.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "PopUpWidget2", Title = "PopUpWidget2", SectionName = "MvcWidgets")]
    public class PopUpWidgetController : Controller
    {
        [Category("String Properties")]
        public string Text { get; set; }

        public ActionResult Index()
        {
            var model = new PopUpWidgetModel();

            if (string.IsNullOrEmpty(this.Text))
            {
                model.Text = "Our Heart of Giving Podcast fosters an atmosphere of benevolence and service through showcasing stories of active donors who have a passion for giving, making a difference, and inspiring others. We feature dialogues with the power to strengthen our understanding of generosity and the transformative impact that giving has on the human spirit and our society as a whole. By highlighting these narratives, we're able to gain in-depth insights into the motivations that form the basis of giving and service.";
            }
            else
            {
                model.Text = this.Text;
            }

            return View("Default", model);
        }
    }
}