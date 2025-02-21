using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Camping_Neretva.Model
{
    public class PaymentModel
    {
        public int PaymentId { get; set; }
        public int ReservationId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
