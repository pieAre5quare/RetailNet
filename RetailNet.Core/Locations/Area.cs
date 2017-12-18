using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RetailNet.Core.Locations
{
    public class Area
    {
        
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public bool IsActive { get; set; }


        public DateTime? CreatedDate { get; set; }
        public int CorporateID { get; set; }
        public Corporate Corporate { get; set; }

        //public int AreaLeaderID { get; set; } 

        //public virtual ApplicationUser AreaLeader { get; set; }

        public virtual ICollection<Region> Regions { get; set; }
        //public virtual ICollection<AreaHistory> Histories { get; set; }
        public Area()
        {
            Regions = new HashSet<Region>();
            //Histories = new HashSet<AreaHistory>();
        }



    }
}
