using Microsoft.AspNetCore.Mvc;

namespace CssPlayground.Web.Controllers
{
    public class CustomHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}