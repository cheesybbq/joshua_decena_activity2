using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPTActivity1.Controllers
{
    public class ProfileController : Controller
    {
        public ViewResult PersonalInfo()
        {
            return View("Activity1");
        }
        public string Date(int month, int date, int year)
        {
            return "Today is " + month + " " + date + "," + year;
        }
        public ViewResult NameAge(int age, string name)
        {
            ViewBag.age = age;
            ViewBag.Name = name;
            return View("NameAge");
        }
    }
}   