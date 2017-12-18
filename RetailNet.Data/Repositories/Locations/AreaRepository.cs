using RetailNet.Core.Locations;
using RetailNet.Data.Repositories.Interfaces.Locations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailNet.Data.Repositories.Locations
{
    public class AreaRepository : Repository<Area>, IAreaRepository
    {
        public AreaRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public override void Add(Area entity)
        {
            //update external data source
            _context.Areas.Add(entity);
            //create history 

        }


        public override void AddRange(IEnumerable<Area> entities)
        {
            //update external data source
            foreach (var entity in entities)
                Add(entity);
            //create history
        }



        public override void Remove(Area entity)
        {
            //update external data source
            entity.IsActive = false;
            //create history
        }

        public override void RemoveRange(IEnumerable<Area> entites)
        {
            //update external data source
            foreach (var entity in entites)
                Remove(entity);
            //create history
        }
        
    }
}
