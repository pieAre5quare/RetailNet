using System;
using System.Collections.Generic;
using System.Text;

namespace RetailNet.Core.Locations
{
    public class OperatingHours
    {
        public int ID { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan Open { get; set; }
        public TimeSpan Close { get; set; }
    }
}
