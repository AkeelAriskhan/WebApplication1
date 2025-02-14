using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            List<Course> courses = new List<Course>
            {
                new Course { Id = 1, Name = "ASP.NET MVC", Instructor = "John Doe", DurationWeeks = 6 },
                new Course { Id = 2, Name = "Angular", Instructor = "Jane Smith", DurationWeeks = 8 },
                new Course { Id = 3, Name = "Flutter", Instructor = "Mike Johnson", DurationWeeks = 10 }
            };

            return View(courses);
            
        }
    }
}