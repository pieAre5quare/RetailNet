using System;
using System.Collections.Generic;
using System.Text;

namespace RetailNet.Data.Services.RqApiService
{
    public class RqApiDivision
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public List<Role> Roles { get; set; }
        public string ClientEntityId { get; set; }
        public DateTime CreatedUtc { get; set; }
        public DateTime LastModifiedUtc { get; set; }


        public List<object> Relationships { get; set; }
        public string SortName { get; set; }

    }

    public class Role
    {
        public string Name { get; set; }
    }
}
