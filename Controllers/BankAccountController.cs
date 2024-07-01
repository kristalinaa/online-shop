using Microsoft.AspNetCore.Mvc;

namespace prov.Controllers
{
    public class BankAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
