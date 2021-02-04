using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcTraining.Models
{
    public class Meeting
    {
        public Meeting()
        {
            this.MeetingAttendees = new HashSet<MeetingAttendee>();
            this.Meetings1 = new HashSet<Meeting>();
        }

        public int MeetingID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? RoomID { get; set; }
        public bool IsAllDay { get; set; }
        public string RecurrenceRule { get; set; }
        public int? RecurrenceID { get; set; }
        public string RecurrenceException { get; set; }
        public string StartTimezone { get; set; }
        public string EndTimezone { get; set; }

        public virtual ICollection<MeetingAttendee> MeetingAttendees { get; set; }
        public virtual ICollection<Meeting> Meetings1 { get; set; }
        public virtual Meeting Meeting1 { get; set; }
    }
}