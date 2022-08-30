using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using asp.net.Models;

namespace asp.net.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
            Student std1 = new Student { Name="Duygu" , Surname="Hesenzade" , Age=17};
            Student std2 = new Student { Name = "Kemale", Surname = "Camalova", Age = 21 };
            Student std3 = new Student { Name = "Xeyal", Surname = "Memmedzade", Age = 25 };
            List<Student> students = new List<Student>();
            students.Add(std1);
            students.Add(std2);
            students.Add(std3);

            return View(students);
        }
        public IActionResult About()
        {
            return View();
        }

       
    }
}
