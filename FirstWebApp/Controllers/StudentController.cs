using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
	public class StudentController : Controller
	{
		private List<Student> _students = new List<Student>
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

		public IActionResult Index()
		{
			return View(_students);
		}
		public IActionResult Details(int? id) 
		{
			if (id == null)
				return NotFound();
			var student = _students.FirstOrDefault(x => x.Id == id);
			
			if (student == null)
				return NotFound();

			return View();
		}
	}
}
