using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    [Serializable]
    public class Subject
    {
        public string ID { get; private set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public List<Teacher> Teachers { get; set; }
        private Subject()
        { }

        public Subject(string title, string type)
        {
            ID = Guid.NewGuid().ToString();
            Title = title;
            Type = type;
        }
    }
}
