using MvcRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcRestApi.ChapterData
{
    public class ChapterList
    {

        public static List<Chapter> ChapterLists = new List<Chapter>()
           {

           new Chapter
           {
               Id = 1,
               Name="Bilgisayar Mühendisliği",
               FacultyName=FacultyData.FacultyList.FacultyLists[0].Name


           },
               new Chapter
               {
                   Id = 2,
                   Name = "Eczacılık",
                   FacultyName =FacultyData.FacultyList.FacultyLists[1].Name


               }


           };
    }
}