using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelBookingApplication.Models
{
    public class TourPackage
    {
        public int PackageID { get; set; }
        public int AgencyID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }
        public int MaxGroupSize { get; set; }
        public virtual TravelAgency TravelAgency { get; set; }
        public virtual ICollection<TourData> TourDates { get; set; }
    }
}