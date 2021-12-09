using MvcRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcRestApi.OgrenciData
{
    public class OgrenciList
    {
        public static List<Student> StudentList = new List<Student>()
        {

            new Student
            {
                Id = 1,
               Name= "Fatma",
                LastName="Güngör",
                TcNo = 41698796323,
               ChapterName=ChapterData.ChapterList.ChapterLists[0].Name,
                FacultyName=FacultyData.FacultyList.FacultyLists[0].Name

            }



        };
    }
}