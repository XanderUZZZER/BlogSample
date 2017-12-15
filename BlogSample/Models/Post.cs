using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSample.Models
{
    public abstract class Post
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public DateTime? Date { get; set; }
        public string Text { get; set; }
    }
}