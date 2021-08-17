using HomeWork17._08._21.Models;
using HomeWork17._08._21.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork17._08._21.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //string id =(string) RouteData.Values["id"];
            //string con = (string)RouteData.Values["controller"];
            //return Content(con);
            //string id = HttpContext.Request.Query["id"];
            //ViewData["Name"] = "Vusal";
            //ViewBag.Surname = "Khalil";
            //TempData["Age"] = 25;
            //return RedirectToAction(nameof(About));

            List<int> numbers = new List<int> { 50, 75, 81, 97, 83, 57, 91 };

            List<Students> students = new List<Students>
            {

                new Students{Id=1,Name="Vusal",Surname="Khalil",Phone=0552515844},
                new Students{Id=2,Name="Elvin",Surname="Jafarli",Phone=0552515844},
                new Students{Id=3,Name="Huseyn",Surname="Azizov",Phone=0552515844},
                new Students{Id=4,Name="Camal",Surname="Ismayilov",Phone=0552515844},
                new Students{Id=5,Name="Murad",Surname="Mirzeyev",Phone=0552515844},
                new Students{Id=6,Name="Emin",Surname="Bagirov",Phone=0552515844},
                new Students{Id=7,Name="Orxan",Surname="Ekberov",Phone=0552515844}


            };

            HomeViewModel model = new HomeViewModel
            {
                Students = students,
                Numbers = numbers
            };

            return View(model);
            
        }

     
    }
}
