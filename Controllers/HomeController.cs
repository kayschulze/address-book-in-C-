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
            return View();
        }

        [HttpPost("/contact/new")]
        public ActionResult NewContact()
        {
            string newName = Request.Form["name"];
            string newPhone = Request.Form["phone"];
            string newAddress = Request.Form["address"];

            Contact newContact = new Contact(newName, newPhone, newAddress);
            return View(newContact);
        }
    }
}
