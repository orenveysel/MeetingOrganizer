using MeetingOrganizer.DAL.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeetingOrganizer.MVC.Controllers
{
    public class MeetingController : Controller
    {
        private readonly AppDbContext _context;

        public MeetingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
