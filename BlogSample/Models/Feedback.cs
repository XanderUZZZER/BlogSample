using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSample.Models
{
    public class Feedback : Post
    {
        public Feedback()
        {

        }
        public Feedback(int personId, string text) : base(personId, text)
        {
        }
    }
}