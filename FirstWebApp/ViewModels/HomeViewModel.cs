using FirstWebApp.Models;

namespace FirstWebApp.ViewModels
{
	public class HomeViewModel
	{
		public List<Student> Students { get; set;} = new List<Student>();
		public List<University> Universities { get; set; } = new List<University>();

	}
}
