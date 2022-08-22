using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using csharp_project.Models;
// using csharp_project

namespace csharp_project.Controllers;

public class HomeController : Controller
{
    private readonly snipR _snipR;

    public HomeController(snipR snipReposi)
    {
    //    ProviderAliasAttribute readonly 
    _snipR = snipReposi;
    }

    public IActionResult Index()
    {
        var snipT = _snipR.GetSnip();
        // var viewModel = new snipViewModel;
        return View();
    }


}
