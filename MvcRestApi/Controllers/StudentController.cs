using MvcRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcRestApi.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        
        public ActionResult Index()
        {

            return View(OgrenciData.OgrenciList.StudentList.OrderBy(s => s.Id).ToList());
            
        }
        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student newStudent)
        {
            try
            {
                Student addStudent = new Student()
                {
                    Name = newStudent.Name,
                    LastName = newStudent.LastName,
                    TcNo = newStudent.TcNo,
                    ChapterName = newStudent.ChapterName,
                    FacultyName = newStudent.FacultyName


                };
                OgrenciData.OgrenciList.StudentList.Add(addStudent);
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }
        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }



       
     
        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            
                var data = OgrenciData.OgrenciList.StudentList.Where(x => x.Id == id).FirstOrDefault();
                return View(data);
         

        }

        // To specify that this will be 
        // invoked when post method is called
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( Student std)
        {
            //update student in DB using EntityFramework in real-life application

            //update list by removing old student and adding updated student for demo purpose
            var student = OgrenciData.OgrenciList.StudentList.Where(s => s.Id == std.Id).FirstOrDefault();
            OgrenciData.OgrenciList.StudentList.Remove(student);
            OgrenciData.OgrenciList.StudentList.Add(std);

            return RedirectToAction("Index");

           
       
        }
            

        // GET: Student/Delete
        public ActionResult Delete()
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            
            var data = OgrenciData.OgrenciList.StudentList.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                OgrenciData.OgrenciList.StudentList.Remove(data);
                return RedirectToAction("Index");
            }
            else
                return View();
            
        }
    }
}
