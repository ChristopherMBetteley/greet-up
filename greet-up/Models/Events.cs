using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace greet_up.Models
{
    public class Events
    {
        [Key]
        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventLocation { get; set; }
        public string EventDescription { get; set; }

        [ForeignKey("Attendees")]
        public int AttendeesID { get; set; }
        public string AttendeeName { get; set; }
        public string AttendeeEmail { get; set; }
    }
}