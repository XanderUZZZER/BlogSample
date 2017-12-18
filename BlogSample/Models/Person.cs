using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSample.Models
{
    public class Person
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Sex? Sex { get; private set; }
        public DateTime? BirthDay { get; private set; }
        public List<Skill> Skills { get; private set; }

        public Person(string name)
        {
            this.Name = name;
        }
    }
}