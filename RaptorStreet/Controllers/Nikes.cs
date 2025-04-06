using Microsoft.AspNetCore.Mvc;
using RaptorStreet.Models;
using System.Diagnostics;
public class NikesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
