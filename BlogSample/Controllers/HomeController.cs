using BlogSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSample.Controllers
{
    public class HomeController : Controller
    {
        BlogContext db = new BlogContext();

        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<Article> articles = db.Articles;
            IEnumerable<Person> persons = db.Persons;
            ViewBag.Articles = articles;
            ViewBag.Persons = persons;

            return View();
        }

        [HttpPost]
        public ActionResult Index(string name, string title, string article)
        {
            if (!db.Persons.Select(p => p.Name).Contains(name))
            {
                db.Persons.Add(new Person(name));
                db.SaveChanges();
            }
            db.Articles.Add(new Article(db.Persons.Where(p => p.Name == name).Select(p => p.Id).First(), title, article));
            db.SaveChanges();
            return Index();
        }
    }
}