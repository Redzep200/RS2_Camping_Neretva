using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Camping_Neretva.Model
{
    public class ReviewModel
    {
        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public int WorkerId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
