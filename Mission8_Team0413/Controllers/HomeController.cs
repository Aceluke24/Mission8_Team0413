using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission8_Team0413.Models;

namespace Mission8_Team0413.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult QuadrantsView()
    {
        return View();
    }
}