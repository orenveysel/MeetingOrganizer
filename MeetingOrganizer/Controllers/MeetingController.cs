using Microsoft.AspNetCore.Mvc;

namespace MeetingOrganizer.MVC.Controllers
{
    public class MeetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
