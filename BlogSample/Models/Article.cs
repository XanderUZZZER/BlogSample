using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSample.Models
{
    public class Article : Post
    {
        public string Title { get; set; }

        public Article()
        {

        }

        public Article(int personId, string title, string article) : base (personId, article)
        {
            Title = title;
        }
    }
}