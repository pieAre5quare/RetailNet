using RetailNet.Core.Locations;
using RetailNet.Data.Repositories.Interfaces.Locations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailNet.Data.Repositories.Locations
{
    public class CorporateOfficeRepository : Repository<CorporateOffice>, ICorporateOfficeRepository
    {
        public CorporateOfficeRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }

}
