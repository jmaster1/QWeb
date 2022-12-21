using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using QModel;
using QWeb.Models;

namespace QWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public static string Name => QModelClass.GetName();

    public IActionResult Index()
    {
        //var x = QModelClass.GetName();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}