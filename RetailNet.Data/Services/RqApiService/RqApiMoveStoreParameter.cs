using System;
using System.Collections.Generic;
using System.Text;

namespace RetailNet.Data.Services.RqApiService
{
    public class RqApiMoveStoreParameter
    {
        public List<int> SubjectIds { get; set; }
        public int DestinationId { get; set; }
    }
}
