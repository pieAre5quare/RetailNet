using System;
using System.Collections.Generic;
using System.Text;

namespace RetailNet.Data.Services.RqApiService
{
    public interface IRqApiService
    {
        void CheckToken();
        int CreateDivision(int parentID, RqApiDivision division, CorporateStructure level);
        int CreateStore(int parentID, RqApiStore store);
        void UpdateStore(int parentID, RqApiStore store);
        void MoveStore(int targetParentID, int storeID);
    }
}
