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
            List<Contact> allContacts = Contact.GetAll();
            return View(allContacts);
        }

        [HttpPost("/")]
        public ActionResult IndexContacts()
        {
            List<Contact> allContacts = Contact.GetAll();
            return View("Index", allContacts);
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

        [HttpGet("/contact/{contactid}")]
        public ActionResult ContactDetails(int contactid)
        {
            Contact selectedContact = Contact.Find(contactid);
            return View(selectedContact);
        }

        [HttpGet("/contacts/clear/safeguardall")]
        public ActionResult SafeGuardAllContacts() {
          return View();
        }


        [HttpGet("/contacts/clear")]
        public ActionResult ClearContacts()
        {
            Contact.ClearAll();

            return View();
        }

        [HttpGet("/contact/{id}/delete/safeguard")]
        public ActionResult ContactSafeGuard(int id, Contact current)
        {
            return View();
        }

        [HttpGet("/contact/{id}/delete")]
        public ActionResult ClearOneContact(int id)
        {
            Contact selectedContact = Contact.Find(id);
            Contact.DeleteContact(selectedContact);
            return View();
        }
    }
}
