using Microsoft.AspNetCore.Mvc;

namespace CRUDEstudiantes.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		public IActionResult Edit(int id)
		{
			return View();
		}

		public IActionResult Delete(int id)
		{
			return View();
		}
	}
}