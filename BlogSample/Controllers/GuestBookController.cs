using BlogSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSample.Controllers
{
    public class GuestBookController : Controller
    {
        BlogContext db = new BlogContext();

        [HttpGet]
        public ActionResult Feedback()
        {
            IEnumerable<Feedback> feedbacks = db.Feedbacks;
            IEnumerable<Person> persons = db.Persons;
            ViewBag.Feedbacks = feedbacks;
            ViewBag.Persons = persons;
            return View();
        }

        [HttpPost]
        public ActionResult Feedback(string name, string feedback)
        {
            if (!db.Persons.Select(p => p.Name).Contains(name))
            {
                db.Persons.Add(new Person(name));
                db.SaveChanges();
            }
            db.Feedbacks.Add(new Feedback(db.Persons.Select(p => p.Id).First(), feedback));
            db.SaveChanges();
            return View();
        }
    }
}