using MvcRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcRestApi.Controllers
{
    public class StudentApiController : ApiController
    {
        // GET: api/StudentApi

        public IEnumerable<Student> Get()
        {
            return OgrenciData.OgrenciList.StudentList;
        }

        // GET: api/StudentApi/5
        public IHttpActionResult Get(int id)
        {
            var searchStudent = (OgrenciData.OgrenciList.StudentList.Where(x => x.Id == id)).FirstOrDefault();
            if (searchStudent == null)
                return NotFound();
            else
                return Ok(searchStudent);
        }

        // POST: api/StudentApi
        public IHttpActionResult Post([FromBody] Student newStudent)
        {
            var studentName = newStudent != null ? newStudent.Name : "";
            var studentLastName = newStudent != null ? newStudent.LastName : "";
            var tcNo = newStudent?.TcNo ?? 0;
            var ChapterName = newStudent != null ? newStudent.ChapterName : "";
            var FacultyName = newStudent != null ? newStudent.FacultyName : "";
            OgrenciData.OgrenciList.StudentList.Add(newStudent);
            return Ok(studentName);

        }

        // PUT: api/StudentApi/5
        public void Put(int id, [FromBody] string value)
        {
        }
        [HttpPut]
        public IHttpActionResult Put(Student student)
        {
            
           


            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");


            var putOgrenci = OgrenciData.OgrenciList.StudentList.FirstOrDefault(k => k.Id == student.Id);

            if (putOgrenci!= null)
                {
                putOgrenci.Name = student.Name;
                putOgrenci.TcNo = student.TcNo;
                putOgrenci.LastName = student.LastName;
                putOgrenci.ChapterName = student.ChapterName;
                putOgrenci.FacultyName = student.FacultyName;
            }
                else
                {
                    return NotFound();
                }
            

            return Ok();
        
    }

        // DELETE: api/StudentApi/5
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid student id");
            var searchStudent = (OgrenciData.OgrenciList.StudentList.Where(x => x.Id == id)).FirstOrDefault();
            if (searchStudent == null)
                return NotFound();
            else
                OgrenciData.OgrenciList.StudentList.Remove(searchStudent);
                return Ok(searchStudent);


            
        }
    }

}
