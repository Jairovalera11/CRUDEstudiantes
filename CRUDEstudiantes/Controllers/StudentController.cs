using Microsoft.AspNetCore.Mvc;

namespace CRUDEstudiantes.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}