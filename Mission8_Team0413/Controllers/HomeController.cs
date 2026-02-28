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
        var completedTasks = _repo.Tasks.Where(t => t.Completed == true).ToList();
        return View(completedTasks);
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
        ViewBag.Categories = _repo.Categories;
        var task = _repo.Tasks.FirstOrDefault(x => x.TaskId == taskId);
        return View("Add", task);
    }

    

    [HttpGet]
    public IActionResult Delete(int taskId)
    {
        _repo.DeleteTask(taskId);
        return RedirectToAction("QuadrantsView");
    }
    
    [HttpGet]
    public IActionResult Add()
    {
        ViewBag.Categories = _repo.Categories;
        return View();
    }
    
    
    [HttpPost]
    public IActionResult Add(Task task)
    {
        if (task.TaskId == 0)
        {
            _repo.AddTask(task);
        }
        else
        {
            _repo.UpdateTask(task);
        }
            return RedirectToAction("QuadrantsView");
    }
    
    [HttpGet]
    public IActionResult MarkComplete(int taskId)
    {
        var task = _repo.Tasks.FirstOrDefault(x => x.TaskId == taskId);
        task.Completed = true;
        _repo.UpdateTask(task);
        return RedirectToAction("QuadrantsView");
    }
    
    [HttpGet]
    public IActionResult UnmarkComplete(int taskId)
    {
        var task = _repo.Tasks.FirstOrDefault(x => x.TaskId == taskId);
        task.Completed = false;
        _repo.UpdateTask(task);
        return RedirectToAction("Index");
    }

}