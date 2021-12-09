using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MvcRestApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        [DisplayName("Name :")]
        public string Name { get; set; }
        [DisplayName("LastName: ")]
        public string LastName { get; set; }
        [DisplayName("Tc-No : ")]
        public long TcNo { get; set; }

        [DisplayName("Chapter:")]
        public string ChapterName { get; set; }
        public virtual Chapter Chapters { get; set; }

        [DisplayName("Faculty :")]
        public string FacultyName{ get; set; }
        public virtual Faculty Faculties { get; set; }



    }
}