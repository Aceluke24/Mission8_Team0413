using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission8_Team0413.Models;

namespace Mission8_Team0413.Controllers;

public class HomeController : Controller
{
    private ITaskRepository _repo;
    
    public HomeController(ITaskRepository repo)
    {
        _repo = repo;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult QuadrantsView()
    {
        return View();
    }
}