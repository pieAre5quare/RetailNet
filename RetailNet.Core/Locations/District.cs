using System;
using System.Collections.Generic;
using System.Text;

namespace RetailNet.Core.Locations
{
    public class District
    {
        
        public int ID { get; set; }
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        //public int DistrictLeaderID { get; set; }
        public int RegionID { get; set; }

        //public virtual ApplicationUser DistrictLeader { get; set; }
        public virtual Region Region { get; set; }

        public virtual ICollection<Store> Stores { get; set; }

        public District()
        {
            Stores = new HashSet<Store>();
        }
    }
}
