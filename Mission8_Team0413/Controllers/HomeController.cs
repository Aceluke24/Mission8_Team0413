using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission8_Team0413.Models;
using Task = Mission8_Team0413.Models.Task;

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
        var tasks = _repo.Tasks;
        return View(tasks);
    }

    [HttpGet]
    public IActionResult Edit(int taskId)
    {
        var task = _repo.Tasks.FirstOrDefault(x => x.TaskId == taskId);
        return View(task);
    }

    [HttpPost]
    public IActionResult Edit(Task task)
    {
        _repo.UpdateTask(task);
        return RedirectToAction("QuadrantsView");
    }

    public IActionResult Delete(int taskId)
    {
        _repo.DeleteTask(taskId);
        return RedirectToAction("QuadrantsView");
    }
}