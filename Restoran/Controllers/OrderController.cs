using Microsoft.AspNetCore.Mvc;
using Restoran.Data.Enum;
using Restoran.Data.Services;
using Restoran.Models;

namespace Restoran.Controllers;

public class OrderController : Controller
{
    private readonly IService _service;

    public OrderController(IService service)
    {
        _service = service;
    }

    // GET
    [HttpGet]
    public  IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(Order order)
    {
        if(!ModelState.IsValid)
        {
            return View();
        }
    
         var purchase = order;
         if (purchase.Burger == Burger.Mini)
         {
             purchase.Price = 10;
              await _service.Add(purchase);
         }
         else if (purchase.Burger == Burger.Middle)
         {
             purchase.Price = 20;
             await _service.Add(purchase);
         }
         else if (purchase.Burger == Burger.Max)
         {
             purchase.Price = 30;
             await _service.Add(purchase);
         }


         return RedirectToAction("Index", "Home");
    }
    
}