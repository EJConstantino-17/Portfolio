using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class LeonorController : Controller
    {
        public IActionResult Index()
        {
            var model = new LeonorViewModel();
            return View(model);
        }
    }
}