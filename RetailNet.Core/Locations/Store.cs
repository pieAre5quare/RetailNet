using System;
using System.Collections.Generic;
using System.Text;

namespace RetailNet.Core.Locations
{
    public class Store
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public int StreetNumber { get; set; }
        public string StreetNumberSuffix { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public bool IsActive { get; set; }




        //public int StoreLeaderID { get; set; }
        public int DistrictID { get; set; }
        //public int StoreExternalReferencesID { get; set; }

        //public virtual ApplicationUser StoreLeader { get; set; }
        public virtual District District { get; set; }
        //public virtual StoreExternalReferences ExternalReferences { get; set; }

        //public virtual ICollection<ApplicationUser> SalesReps { get; set; }
        public virtual ICollection<OperatingHours> Hours { get; set; }

        public Store()
        {
            //SalesReps = new HashSet<ApplicationUser>();
            Hours = new HashSet<OperatingHours>();
        }
    }
}
