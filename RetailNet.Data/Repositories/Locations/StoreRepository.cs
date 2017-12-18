using RetailNet.Core.Locations;
using RetailNet.Data.Repositories.Interfaces.Locations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailNet.Data.Repositories.Locations
{
    public class StoreRepository : Repository<Store>, IStoreRepository
    {
        public StoreRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public override void Add(Store entity)
        {
            //update external data source
            base.Add(entity);
            //create history
        }
        public new Store Update(Store entity)
        {
            //update external data source      
            base.Update(entity);
            return entity;
            //create history
        }
    }
}
