using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogSample.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Skill> Skills { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    Database.SetInitializer<BlogContext>(null);
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}