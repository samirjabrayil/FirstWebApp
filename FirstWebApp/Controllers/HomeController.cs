using FirstWebApp.Models;
using FirstWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Name = "Samir",
                    Age = 20,
                },

                new Student
                {
                    Id = 2,
                    Name = "Osman",
                    Age = 19,
                },
                new Student
                {
                    Id = 3,
                    Name = "Senan",
                    Age = 19,
                },
            };

            var universities = new List<University>
            {
                new University { Id =1, Name = "Azerbaijan Technical University"},
                new University { Id =2, Name = "Baku State University"},
				new University { Id =3, Name = "Azerbaijan University"},
			};

            var viewModel = new HomeViewModel
            {
                Students = students,
                Universities = universities,
            };
			return View(viewModel);
        }
    }
}
