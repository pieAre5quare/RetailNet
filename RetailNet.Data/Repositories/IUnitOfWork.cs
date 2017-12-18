using RetailNet.Data.Repositories.Interfaces;
using RetailNet.Data.Repositories.Interfaces.Locations;
using RetailNet.Data.Repositories.Locations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailNet.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Areas = new AreaRepository(_context);
            Regions = new RegionRepository(_context);
            Districts = new DistrictRepository(_context);
            Stores = new StoreRepository(_context);
            CorporateOffices = new CorporateOfficeRepository(_context);

        }
        public IAreaRepository Areas { get; private set; }

        public IRegionRepository Regions { get; private set; }

        public IDistrictRepository Districts { get; private set; }

        public IStoreRepository Stores { get; private set; }

        public ICorporateOfficeRepository CorporateOffices { get; private set; }

        // returns number of changes
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
