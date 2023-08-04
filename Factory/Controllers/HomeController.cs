using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;

namespace Factory.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }

}
