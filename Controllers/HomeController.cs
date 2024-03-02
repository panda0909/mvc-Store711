using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_Store711.Models;

namespace mvc_Store711.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [Route("cvs_submit")]
    public IActionResult cvs_submit()
    {
        return View();
    }

    [HttpPost]
    [Route("cvs_callback")]
    public IActionResult cvs_callback()
    {
        string storename = Request.Form["storename"];
        string storeid = Request.Form["storeid"];
        string storeaddress = Request.Form["storeaddress"];
        
        //_logger.LogInformation("storename: " + storename);
        ViewBag.cvsResp = new {
            storename = storename,
            storeid = storeid,
            storeaddress = storeaddress
        };
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
