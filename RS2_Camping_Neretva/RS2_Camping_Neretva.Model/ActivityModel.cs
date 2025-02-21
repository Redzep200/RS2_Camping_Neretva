using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Camping_Neretva.Model
{
    public class ActivityModel
    {
        public int ActivityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public int FacilityId { get; set; }
    }
}
