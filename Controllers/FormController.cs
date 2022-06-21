using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormWithValidations.Models;

namespace FormWithValidations.Controllers;

public class FormController : Controller
{
    private readonly ILogger<FormController> _logger;

    public FormController(ILogger<FormController> logger)
    {
        _logger = logger;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost("process")]
    public IActionResult process(User newUser)
    {
        if(ModelState.IsValid)
        {
        return RedirectToAction("Result", newUser);
        } else {
            return View("Index");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult Result(User newUser)
    {
        return View(newUser);
    }
}
