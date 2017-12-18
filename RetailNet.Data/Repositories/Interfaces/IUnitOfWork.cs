using RetailNet.Data.Repositories.Interfaces.Locations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailNet.Data.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAreaRepository Areas { get; }
        IRegionRepository Regions { get; }
        IDistrictRepository Districts { get; }
        IStoreRepository Stores { get; }
        ICorporateOfficeRepository CorporateOffices { get; }
        int Complete();
    }
}
