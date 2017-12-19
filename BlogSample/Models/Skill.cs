using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogSample.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        public SkillItem SkillItem { get; set; }
        public virtual ICollection<Person> Persons { get; set; }

        public Skill()
        {
            Persons = new List<Person>();
        }
        public Skill(SkillItem skill)
        {
            SkillItem = skill;
            Persons = new List<Person>();
        }
    }
}