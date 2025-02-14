using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Details()
        {
            // Create a list of students
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Alice", Age = 20, Course = "Computer Science" },
                new Student { Id = 2, Name = "Bob", Age = 22, Course = "Mechanical Engineering" },
                new Student { Id = 3, Name = "Charlie", Age = 21, Course = "Electrical Engineering" }
            };
            ViewData["Students"] = students;
            return View();
        }
    }
}