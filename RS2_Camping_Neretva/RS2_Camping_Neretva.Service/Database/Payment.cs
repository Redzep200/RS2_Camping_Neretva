﻿using System;
using System.Collections.Generic;

namespace RS2_Camping_Neretva.Service.Database;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int? ReservationId { get; set; }

    public int? UserId { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? TransactionDate { get; set; }

    public virtual Reservation? Reservation { get; set; }

    public virtual User? User { get; set; }
}
