using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TravelBookingApplication.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int TouristID { get; set; }
        public int TourDataID { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; }
        public string PaymentStatus { get; set; }
        public virtual Tourist Tourist { get; set; }
        public virtual TourData TourData { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }

    }
}