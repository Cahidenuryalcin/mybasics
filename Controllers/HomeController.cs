﻿using Microsoft.AspNetCore.Mvc;

namespace mybasics.Controllers;
public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

}