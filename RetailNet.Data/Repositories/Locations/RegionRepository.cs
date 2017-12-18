using RetailNet.Core.Locations;
using RetailNet.Data.Repositories.Interfaces.Locations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailNet.Data.Repositories.Locations
{
    public class RegionRepository : Repository<Region>, IRegionRepository
    {
        private IRqApiService _service;

        public RegionRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public override void Add(Region entity)
        {
            //update external data source
            _context.Regions.Add(entity);
            //create history 
        }

        public override void Remove(Region entity)
        {
            //update external data source
            entity.IsActive = false;
            //create history
        }
    }
}
