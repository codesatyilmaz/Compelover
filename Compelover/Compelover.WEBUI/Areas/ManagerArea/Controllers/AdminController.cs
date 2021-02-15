using Microsoft.AspNetCore.Mvc;

namespace Compelover.WEBUI.Areas.ManagerArea.Controllers
{
    public class AdminController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}