using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelBookingApplication.Models
{
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public int BookingID { get; set; }
        public int TouristID { get; set; }
        public int Rating {  get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual Tourist Tourist { get; set; }

    }
}