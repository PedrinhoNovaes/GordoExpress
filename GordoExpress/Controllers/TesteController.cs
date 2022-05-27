using Microsoft.AspNetCore.Mvc;

namespace GordoExpress.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
