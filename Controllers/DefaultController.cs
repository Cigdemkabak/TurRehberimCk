using Microsoft.AspNetCore.Mvc;

namespace TurRehberimCK.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
