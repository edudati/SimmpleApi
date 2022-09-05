using Microsoft.AspNetCore.Mvc;

namespace SimpleApi.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
