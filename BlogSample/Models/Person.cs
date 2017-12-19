using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSample.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Sex? Sex { get; set; }
        public DateTime? BirthDay { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }

        public Person()
        {
            Skills = new List<Skill>();
        }

        public Person(string name)
        {
            this.Name = name;
        }
    }
}