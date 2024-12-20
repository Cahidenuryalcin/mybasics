using Microsoft.AspNetCore.Mvc;
using mybasics.Models;

namespace mybasics.Controllers;

public class CourseController : Controller
{
    public IActionResult Details(int? id)
    {
        if (id==null)
        {
            // return Redirect("/course/list");
            return RedirectToAction("List","Course");
        }
        var course = Repository.GetById(id);
        
        return View(course);
    }
    public IActionResult List()
    {
        return View(Repository.Courses);
    }
}