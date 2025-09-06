using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelBookingApplication.Models
{
    public class Tourist
    {
        public int TouristID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string ContactNumber { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }

    }
}