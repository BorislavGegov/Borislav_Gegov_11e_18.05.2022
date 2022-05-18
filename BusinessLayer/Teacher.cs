using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLayer
{
    [Serializable]
    public class Teacher
    {
        
        public string ID { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Experience { get; set; }
        public List<Subject> Subjects { get; set; }
        private Teacher()
        { }

        public Teacher(string name, int age,string experience)
        {
            this.ID = Guid.NewGuid().ToString();
            Name = name;
            Age = age;
            Experience = experience;
        }
    }
}
