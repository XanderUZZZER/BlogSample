using BlogSample.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BlogSample.Controllers
{
    public class QuestionnaireController : Controller
    {
        BlogContext db = new BlogContext();
        

        public ActionResult Info()
        {
            if ("GET" == this.HttpContext.Request.RequestType)
            {
                IEnumerable<Skill> skills = db.Skills;
                ViewBag.Skills = skills;
                return View();
            }

            string name  =  Request.Params["name"];
            
            Person person;
            if (!db.Persons.Select(p => p.Name).Contains(name))
            {
                person = new Person(name);
                db.Persons.Add(person);
            }
            else
            {
                person = db.Persons.Where(p => p.Name == name).First();
            }
            person.Sex = (Sex)Enum.Parse(typeof(Sex), Request.Params["sex"].ToString());
            ViewBag.Person = person;

            db.SaveChanges();
            return View("Result");
        }

        
        //public ActionResult UpdateInfo(FormCollection collection)
        //{
        //    string name = collection["name"].ToString();
        //    Person person;
        //    if (!db.Persons.Select(p => p.Name).Contains(name))
        //    {
        //        person = new Person(name);
        //        db.Persons.Add(person);
        //    }
        //    else
        //    {
        //        person = db.Persons.Where(p => p.Name == name).First();
        //    }
        //    person.Sex = (Sex)Enum.Parse(typeof(Sex), collection["sex"].ToString());
        //    //foreach (var sk in collection["skill"])
        //    //{
        //    //    person.Skills.Add(new Skill((SkillItem)Enum.Parse(typeof(SkillItem), sk.ToString())));
        //    //}
        //    db.SaveChanges();
        //    return View();
        //}
    }
}