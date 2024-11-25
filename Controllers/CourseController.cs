using Microsoft.AspNetCore.Mvc;
using mybasics.Models;

namespace mybasics.Controllers;

public class CourseController: Controller{
    public IActionResult Index(){
        var kurs= new Course();
        kurs.Id=1;
        kurs.Title="asp kursu";
        kurs.Description="harika bir set";
        kurs.Image="1.jpg";
        return View(kurs);
    }
    public IActionResult List(){
        var kurslar = new List<Course>(){
            new Course(){
                Id=1,
                Title="asp kursu",
                Description="harika bir kurs",
                Image="1.jpg",
            },
            new Course(){
                Id=2,
                Title=" php kursu",
                Description="güzel bir kurs",
                Image="2.jpg",
            },
            new Course(){
                Id=3,
                Title="djang kursu",
                Description="mükemmel bir kurs",
                Image="3.jpg",
            },
    
        };

        return View(kurslar);
    }
}