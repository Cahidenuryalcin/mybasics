using Microsoft.AspNetCore.Mvc;
using mybasics.Models;

namespace mybasics.Controllers;
public class HomeController : Controller
{

    public IActionResult Index()
    {

        return View(Repository.Courses);
    }

    public IActionResult Contact()
    {
        return View();
    }

}
