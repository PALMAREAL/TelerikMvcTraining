using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TelerikMvcTraining.Models
{
    public class MeetingAttendee : Entity
    {
        [Key]
        public int AttendeeID { get; set; }

        public int MeetingID { get; set; }

        public virtual Meeting Meeting { get; set; }
    }
}