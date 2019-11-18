using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneBook.WebService;

namespace PhoneBook.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string Search(string phone)
        {
            return new PhonebookService().Get(phone);
        }
    }
}