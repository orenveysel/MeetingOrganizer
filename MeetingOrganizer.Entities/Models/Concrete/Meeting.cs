using MeetingOrganizer.Entities.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingOrganizer.Entities.Models.Concrete
{
    public class Meeting : BaseEntity
    {
        public required string Topic { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public string? Participants { get; set; }
    }
}
