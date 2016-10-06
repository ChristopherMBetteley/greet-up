using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace greet_up.Models
{
    public class Attendees
    {
        public int AttendeesID { get; set; }
        public string AttendeesName { get; set; }
        public string AttendeesEmail { get; set; }
        public virtual ICollection<Events> Events { get; set; }
    }
}