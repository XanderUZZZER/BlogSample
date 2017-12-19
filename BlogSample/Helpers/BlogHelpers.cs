using BlogSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSample.Helpers
{
    public static class BlogHelpers
    {
        public  static  MvcHtmlString CreateCheckedList(this HtmlHelper html, 
                                                   IEnumerable<Skill> skills,
                                                   string name)
        {            
            string returnString = "";
            foreach (var s in skills)
            {
                TagBuilder p = new TagBuilder("p");
                TagBuilder input = new TagBuilder("input");
                input.MergeAttribute("name", name);
                input.MergeAttribute("value", s.SkillItem.ToString());
                input.MergeAttribute("type", "checkbox");
                input.SetInnerText(s.SkillItem.ToString());
                p.InnerHtml = input.ToString();
                returnString += p.ToString();
            }
            return new MvcHtmlString(returnString);
        }
    }
}