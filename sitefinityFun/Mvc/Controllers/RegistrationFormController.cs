using Microsoft.AspNetCore.Mvc;
using sitefinityFun.Mvc.Models;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace sitefinityFun.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "RegistrationWidget", Title = "Registration Form", SectionName = "MvcWidgets")]
    public class RegistrationFormController : Controller
    {
        [Category("String Properties")]

        public string username { get; set; }
        public string user_password { get; set; }
        public string user_password2 { get; set; }
        public string full_name { get; set; }
        public int age { get; set; }

        public ActionResult Index()
        {
            var model = new RegistrationFormModel();

            return View("Default", model);
        }

        [HttpPost]
        public ActionResult Index(RegistrationFormModel person)
        {
            string username = person.username;
            string user_password = person.user_password;
            string full_name = person.full_name;
            int age = person.age;

            return View();
        }
    }

    


}