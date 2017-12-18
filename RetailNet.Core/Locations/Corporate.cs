using System.Collections.Generic;

namespace RetailNet.Core.Locations
{
    public class Corporate
    {

        public int ID { get; set; }
        public string Name { get; set; }



        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<CorporateOffice> CorporateOffices { get; set; }

        public Corporate()
        {
            Areas = new HashSet<Area>();
            CorporateOffices = new HashSet<CorporateOffice>();
        }
    }
}