using System;
using System.Collections.Generic;
using System.Text;

namespace RetailNet.Core.Locations
{
    public class Region
    {
        
        public int ID { get; set; }
        public string Name { get; set; }

        public bool IsActive { get; set; }


        //public int RegionLeaderID { get; set; }
        public int AreaID { get; set; }

        //public virtual ApplicationUser RegionLeader { get; set; }
        public virtual Area Area { get; set; }

        public virtual ICollection<District> Districts { get; set; }

        public Region()
        {
            Districts = new HashSet<District>();
        }
    }
}
