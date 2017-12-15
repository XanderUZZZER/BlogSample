using BlogSample.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BlogSample.Controllers
{
    public class QuestionnaireController : Controller
    {
        List<Person> persons;
        // GET: Questionnaire
        public ActionResult Index()
        {
            return View();
        }
    }
}