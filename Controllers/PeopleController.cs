using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _272_Prac_2.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult ListPeople()
        {
            List<Models.MyClass> people = new List<Models.MyClass>();

            people.Add(new Models.MyClass { StudentNumber = "u23788918", Name = "Sumed", Surname = "Alekar", EmailAddress = "u23788918@tuks.co.za", myLink = "~/HTML/Sumed.html" });
            people.Add(new Models.MyClass { StudentNumber = "u24781569", Name = "Kesivan", Surname = "Naidoo", EmailAddress = "u24781569@tuks.co.za", myLink = "~/HTML/Kesivan.html" });
            people.Add(new Models.MyClass { StudentNumber = "u24728782", Name = "Marques", Surname = "Jaboon", EmailAddress = "u24728782@tuks.co.za", myLink = "~/HTML/Marques.html" });
            people.Add(new Models.MyClass { StudentNumber = "u24116514", Name = "Ethan", Surname = "Harris", EmailAddress = "u24116514@tuks.co.za", myLink = "~/HTML/Ethan.html" });
            people.Add(new Models.MyClass { StudentNumber = "u23010523", Name = "Lily", Surname = "Parker", EmailAddress = "u23010523@tuks.co.za", myLink = "~/HTML/Lily.html" });

            return View(people);
            
        }
    }
}