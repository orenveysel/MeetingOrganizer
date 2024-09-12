using MeetingOrganizer.DAL.DbContexts;
using MeetingOrganizer.Entities.Models.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeetingOrganizer.MVC.Controllers
{
    [Route("Meeting")]
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
        [Route("Create")]
        public IActionResult Create(Meeting meeting)
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
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            var meetings = _context.Meetings.ToList(); // Veritabanından tüm toplantıları çekiyoruz
            return Json(meetings); // JSON olarak geri döndürüyoruz
        }

        // Id ile veri çekme
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var meeting = _context.Meetings.Find(id); // Veritabanından tüm toplantıları çekiyoruz
            if (meeting == null)
            {
                return NotFound();
            }
            return Ok(meeting);
        }

        // Toplantı güncelleme
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Meeting meeting)
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
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
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
