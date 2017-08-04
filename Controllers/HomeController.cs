using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using System.Collections.Generic;
using System;

namespace AddressBook.Contollers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {

      return View();
    }

    // [HttpPost("/contact/new")]
    // public ActionResult CreateTask()
    // {
    //   // Task newTask = new Task (Request.Form["new-task"]);
    //   // newTask.Save();
    //   return View(newTask);
    // }
  }
}
