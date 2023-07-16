using Microsoft.AspNetCore.Mvc;

namespace Restoran.Controllers;

public class AboutController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}