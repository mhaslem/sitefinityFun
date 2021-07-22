using sitefinityFun.Mvc.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Routing;

namespace sitefinityFun.Mvc.Controllers
{
    /*
    [ControllerToolboxItem(Name = "Products", Title = "Products Widget", SectionName = "MvcWidgets")]
    public class ProductsController : Controller
    {
        public ProductsController(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment; 
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); }
        }

        public IEnumerable<ProductsModel> GetProducts()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
    */
}