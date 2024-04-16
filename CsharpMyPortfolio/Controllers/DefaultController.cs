using Microsoft.AspNetCore.Mvc;

namespace CsharpMyPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
