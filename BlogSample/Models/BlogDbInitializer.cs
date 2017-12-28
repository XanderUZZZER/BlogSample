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
            db.Persons.Add(new Person("Tom"));
            db.Persons.Add(new Person("Maggie"));
            db.Persons.Add(new Person("Willy"));
            db.Persons.Add(new Person("Lucy"));
            db.Persons.Add(new Person("Mike"));

            db.Skills.Add(new Skill { SkillItem = SkillItem.Art });
            db.Skills.Add(new Skill { SkillItem = SkillItem.IT });
            db.Skills.Add(new Skill { SkillItem = SkillItem.Literature });
            db.Skills.Add(new Skill { SkillItem = SkillItem.Math });
            db.Skills.Add(new Skill { SkillItem = SkillItem.Sport });
            db.Skills.Add(new Skill { SkillItem = SkillItem.Drugs });

            db.Articles.Add(new Article
            {
                Title = "Article 1",
                Date = DateTime.Now,
                PersonId = 1,
                Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                         Etiam vehicula rhoncus velit non mattis. Donec nec magna ac enim hendrerit sagittis congue sed quam.
                         Curabitur fringilla est tellus, quis tincidunt quam tempus id.Vivamus tempor auctor facilisis.Suspendisse efficitur dignissim aliquam.
                         Aliquam sollicitudin tristique metus quis dapibus.Aenean ultricies et ipsum non elementum.Donec a erat faucibus, finibus urna eu, consectetur ipsum."
            });
            db.Articles.Add(new Article
            {
                Title = "Article 2",
                Date = DateTime.Now,
                PersonId = 2,
                Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                         Etiam vehicula rhoncus velit non mattis. Donec nec magna ac enim hendrerit sagittis congue sed quam.
                         Curabitur fringilla est tellus, quis tincidunt quam tempus id.Vivamus tempor auctor facilisis.Suspendisse efficitur dignissim aliquam.
                         Aliquam sollicitudin tristique metus quis dapibus.Aenean ultricies et ipsum non elementum.Donec a erat faucibus, finibus urna eu, consectetur ipsum."
            });
            db.Articles.Add(new Article
            {
                Title = "Article 3",
                Date = DateTime.Now,
                PersonId = 3,
                Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                         Etiam vehicula rhoncus velit non mattis. Donec nec magna ac enim hendrerit sagittis congue sed quam.
                         Curabitur fringilla est tellus, quis tincidunt quam tempus id.Vivamus tempor auctor facilisis.Suspendisse efficitur dignissim aliquam.
                         Aliquam sollicitudin tristique metus quis dapibus.Aenean ultricies et ipsum non elementum.Donec a erat faucibus, finibus urna eu, consectetur ipsum."
            });
            db.Articles.Add(new Article
            {
                Title = "Article 4",
                Date = DateTime.Now,
                PersonId = 2,
                Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                         Etiam vehicula rhoncus velit non mattis. Donec nec magna ac enim hendrerit sagittis congue sed quam.
                         Curabitur fringilla est tellus, quis tincidunt quam tempus id.Vivamus tempor auctor facilisis.Suspendisse efficitur dignissim aliquam.
                         Aliquam sollicitudin tristique metus quis dapibus.Aenean ultricies et ipsum non elementum.Donec a erat faucibus, finibus urna eu, consectetur ipsum."
            });
            db.Articles.Add(new Article
            {
                Title = "Article 5",
                Date = DateTime.Now,
                PersonId = 3,
                Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                         Etiam vehicula rhoncus velit non mattis. Donec nec magna ac enim hendrerit sagittis congue sed quam.
                         Curabitur fringilla est tellus, quis tincidunt quam tempus id.Vivamus tempor auctor facilisis.Suspendisse efficitur dignissim aliquam.
                         Aliquam sollicitudin tristique metus quis dapibus.Aenean ultricies et ipsum non elementum.Donec a erat faucibus, finibus urna eu, consectetur ipsum."
            });

            db.Feedbacks.Add(new Feedback
            {
                Date = DateTime.Now,
                PersonId = 1,
                Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                         Etiam vehicula rhoncus velit non mattis. Donec nec magna ac enim hendrerit sagittis congue sed quam.
                         Curabitur fringilla est tellus, quis tincidunt quam tempus id.Vivamus tempor auctor facilisis.Suspendisse efficitur dignissim aliquam.
                         Aliquam sollicitudin tristique metus quis dapibus.Aenean ultricies et ipsum non elementum.Donec a erat faucibus, finibus urna eu, consectetur ipsum."
            });
            db.Feedbacks.Add(new Feedback
            {
                Date = DateTime.Now,
                PersonId = 3,
                Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                         Etiam vehicula rhoncus velit non mattis. Donec nec magna ac enim hendrerit sagittis congue sed quam.
                         Curabitur fringilla est tellus, quis tincidunt quam tempus id.Vivamus tempor auctor facilisis.Suspendisse efficitur dignissim aliquam.
                         Aliquam sollicitudin tristique metus quis dapibus.Aenean ultricies et ipsum non elementum.Donec a erat faucibus, finibus urna eu, consectetur ipsum."
            });
            db.Feedbacks.Add(new Feedback
            {
                Date = DateTime.Now,
                PersonId = 4,
                Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                         Etiam vehicula rhoncus velit non mattis. Donec nec magna ac enim hendrerit sagittis congue sed quam.
                         Curabitur fringilla est tellus, quis tincidunt quam tempus id.Vivamus tempor auctor facilisis.Suspendisse efficitur dignissim aliquam.
                         Aliquam sollicitudin tristique metus quis dapibus.Aenean ultricies et ipsum non elementum.Donec a erat faucibus, finibus urna eu, consectetur ipsum."
            });

            base.Seed(db);
        }

    }
}