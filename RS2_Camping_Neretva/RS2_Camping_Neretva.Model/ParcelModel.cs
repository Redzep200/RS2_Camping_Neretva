using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Camping_Neretva.Model
{
    public class ParcelModel
    {
        public int parcelId { get; set; }
        public int parcelNumber { get; set; }
        public string description { get; set; }
        public bool electricity { get; set; }
        public bool shade { get; set; }
    }
}
