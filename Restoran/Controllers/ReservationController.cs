using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Restoran.Data.Services;
using Restoran.Models;
using System.Diagnostics.Contracts;

namespace Restoran.Controllers;

public class ReservationController : Controller
{
    private readonly IService _service;

    public ReservationController(IService service)
    {
        _service = service;
    }

    // GET
    public async Task<IActionResult> Index()
    {
        var items = await _service.GetALl();

        return View(items);
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        Order order = await _service.GetById(id);

        return View(order);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteConf(int id)
    {
        Order order = await _service.GetById(id);

        await _service.Delete(order);

        return RedirectToAction("Index", "Home");
    }


}