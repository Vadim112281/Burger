using Microsoft.AspNetCore.Mvc;

namespace Restoran.Controllers;

public class MenuController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    


}