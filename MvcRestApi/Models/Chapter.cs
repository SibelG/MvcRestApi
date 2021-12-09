using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MvcRestApi.Models
{
    public class Chapter
    {
        public int Id { get; set; }

        [DisplayName("Chapter Name :")]
        public string Name{ get; set; }

        [DisplayName("Faculty:")]
        public string FacultyName { get; set; }
        public virtual Faculty Faculties { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}