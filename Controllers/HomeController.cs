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

    [HttpGet("/contact/add")]
    public ActionResult AddContact()
    {
      // Task newTask = new Task (Request.Form["new-task"]);
      // newTask.Save();
      return View();
    }
  }
}
