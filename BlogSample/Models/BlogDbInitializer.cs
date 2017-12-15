using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogSample.Models
{
    public class BlogDbInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext db)
        {
            db.Articles.Add(new Article
            {
                Title = "Article 1",
                Date = DateTime.Now,
                Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                         Etiam vehicula rhoncus velit non mattis. Donec nec magna ac enim hendrerit sagittis congue sed quam.
                         Curabitur fringilla est tellus, quis tincidunt quam tempus id.Vivamus tempor auctor facilisis.Suspendisse efficitur dignissim aliquam.
                         Aliquam sollicitudin tristique metus quis dapibus.Aenean ultricies et ipsum non elementum.Donec a erat faucibus, finibus urna eu, consectetur ipsum."
            });
            db.Articles.Add(new Article
            {
                Title = "Article 2",
                Date = DateTime.Now,
                Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                         Etiam vehicula rhoncus velit non mattis. Donec nec magna ac enim hendrerit sagittis congue sed quam.
                         Curabitur fringilla est tellus, quis tincidunt quam tempus id.Vivamus tempor auctor facilisis.Suspendisse efficitur dignissim aliquam.
                         Aliquam sollicitudin tristique metus quis dapibus.Aenean ultricies et ipsum non elementum.Donec a erat faucibus, finibus urna eu, consectetur ipsum."
            });
            db.Articles.Add(new Article
            {
                Title = "Article 2",
                Date = DateTime.Now,
                Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                         Etiam vehicula rhoncus velit non mattis. Donec nec magna ac enim hendrerit sagittis congue sed quam.
                         Curabitur fringilla est tellus, quis tincidunt quam tempus id.Vivamus tempor auctor facilisis.Suspendisse efficitur dignissim aliquam.
                         Aliquam sollicitudin tristique metus quis dapibus.Aenean ultricies et ipsum non elementum.Donec a erat faucibus, finibus urna eu, consectetur ipsum."
            });

            base.Seed(db);
        }

    }
}