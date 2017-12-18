using System.Collections.Generic;

namespace RetailNet.Core.Locations
{
    public class CorporateOffice
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int RqID { get; set; }
        public bool IsActive { get; set; }

        public int CorporateID { get; set; }
        public Corporate Corporate { get; set; }

        //public virtual ICollection<ApplicationUser> CorporateEmployees { get; set; }
        public virtual ICollection<OperatingHours> Hours { get; set; }

        public CorporateOffice()
        {
            //CorporateEmployees = new HashSet<ApplicationUser>();
            Hours = new HashSet<OperatingHours>();
        }
    }
}