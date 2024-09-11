using System.ComponentModel.DataAnnotations;

namespace MeetingOrganizer.MVC.Models
{
    public class Meeting
    {
        public int Id { get; set; }

        [Required]
        public string Topic { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

        public string Participants { get; set; }
    }
}
