using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ChangeMe.Contollers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {

      return View();
    }

    [HttpPost("/task/create")]
    public ActionResult CreateTask()
    {
      Task newTask = new Task (Request.Form["new-task"]);
      newTask.Save();
      return View(newTask);
    }
  }
}
