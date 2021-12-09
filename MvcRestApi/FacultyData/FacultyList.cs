using MvcRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcRestApi.FacultyData
{
    public class FacultyList
    {
        public static List<Faculty> FacultyLists = new List<Faculty>()
            {


            new Faculty
            {

                Id = 1,
                Name = "Mühendislik Facultysi"

            },
                new Faculty
                {
                    Id = 2,
                    Name = "Eczacılık Facultysi"

                }

            };
    }
}