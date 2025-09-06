using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TravelBookingApplication.Models
{
    public class TourData
    {
        public int TourDataID { get; set; }
        public int PackageID { get; set; }
        public DateTime AvailableData { get; set; }
        public string Status { get; set; }
        public virtual TourPackage TourPackage { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }

    }
}