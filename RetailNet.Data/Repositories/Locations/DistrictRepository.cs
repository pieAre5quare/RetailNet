using RetailNet.Core.Locations;
using RetailNet.Data.Repositories.Interfaces.Locations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailNet.Data.Repositories.Locations
{
    public class DistrictRepository : Repository<District>, IDistrictRepository
    {
        public DistrictRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public override void Add(District entity)
        {
            //update external data source
            _context.Districts.Add(entity);
            //create history 
        }

        public override void Remove(District entity)
        {
            //update external data source
            entity.IsActive = false;
            //create history
        }
    }
}
