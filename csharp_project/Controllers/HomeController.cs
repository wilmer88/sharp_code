using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// using csharp_project.Models;

namespace csharp_project.Controllers;

public class HomeController : Controller
{


    public HomeController()
    {
    //    ProviderAliasAttribute readonly 
    }

    public IActionResult Index()
    {
        return View();
    }


}
