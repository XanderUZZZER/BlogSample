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

        public ActionResult Index()
        {
            IEnumerable<Article> articles = db.Articles;
            IEnumerable<Person> persons = db.Persons;
            ViewBag.Articles = articles;
            ViewBag.Persons = persons;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}