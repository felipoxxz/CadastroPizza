using Microsoft.AspNetCore.Mvc;

namespace CadastroPizza.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
