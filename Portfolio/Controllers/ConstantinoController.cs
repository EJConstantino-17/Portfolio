using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ConstantinoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
