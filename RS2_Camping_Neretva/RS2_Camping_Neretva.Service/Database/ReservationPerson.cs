﻿using System;
using System.Collections.Generic;

namespace RS2_Camping_Neretva.Service.Database;

public partial class ReservationPerson
{
    public int ReservationId { get; set; }

    public int PersonId { get; set; }

    public int? Quantity { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual Reservation Reservation { get; set; } = null!;
}
