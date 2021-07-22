using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sitefinityFun.Mvc.Models;
using System.ComponentModel;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace sitefinityFun.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "PopUpWGA", Title = "PopUpWGA", SectionName = "MvcWidgets")]
    public class PopUpWGAController : Controller
    {
        [Category("String Properties")]
        public string Text { get; set; }

        public ActionResult Index()
        {
            var model = new PopUpWGA();

            if (string.IsNullOrEmpty(this.Text))
            {
                model.Text = "This is a Test for the Heart of Giving Podcast Pop Up";
            }
            else
            {
                model.Text = this.Text;
            }

            return View("Default", model);
        }
    }
}