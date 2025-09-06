using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelBookingApplication.Models
{
    public class TravelAgency
    {
        public int AgencyID { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string Description { get; set; }
        public string ServicesOffered { get; set; }
        public string ProfileImage { get; set; }
        public virtual ICollection<TourPackage> TourPackages { get; set; }

    }
}