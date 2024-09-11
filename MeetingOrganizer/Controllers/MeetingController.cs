using MeetingOrganizer.DAL.DbContexts;
using MeetingOrganizer.Entities.Models.Concrete;
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

        // Toplantı ekleme
        [HttpPost]
        public JsonResult Create([FromBody] Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                _context.Meetings.Add(meeting); // Toplantıyı veritabanına ekliyoruz
                _context.SaveChanges(); // Veritabanına işlemi kaydediyoruz
                return Json(meeting);
            }
            return Json(null);
        }

        // Tüm toplantıları listeleme
        [HttpGet]
        public JsonResult GetAll()
        {
            var meetings = _context.Meetings.ToList(); // Veritabanından tüm toplantıları çekiyoruz
            return Json(meetings); // JSON olarak geri döndürüyoruz
        }

        // Toplantı güncelleme
        [HttpPost]
        public JsonResult Update([FromBody] Meeting meeting)
        {
            var existingMeeting = _context.Meetings.Find(meeting.Id); // Veritabanından toplantıyı buluyoruz
            if (existingMeeting != null && ModelState.IsValid)
            {
                existingMeeting.Topic = meeting.Topic;
                existingMeeting.Date = meeting.Date;
                existingMeeting.StartTime = meeting.StartTime;
                existingMeeting.EndTime = meeting.EndTime;
                existingMeeting.Participants = meeting.Participants;

                _context.Meetings.Update(existingMeeting); // Güncelliyoruz
                _context.SaveChanges(); // Veritabanına kaydediyoruz

                return Json(existingMeeting);
            }
            return Json(null);
        }

        // Toplantı silme
        [HttpPost]
        public JsonResult Delete(int id)
        {
            var meeting = _context.Meetings.Find(id); // Veritabanından toplantıyı buluyoruz
            if (meeting != null)
            {
                _context.Meetings.Remove(meeting); // Silme işlemi
                _context.SaveChanges(); // Veritabanına işlemi kaydediyoruz
                return Json(meeting);
            }
            return Json(null);
        }
    }
}
