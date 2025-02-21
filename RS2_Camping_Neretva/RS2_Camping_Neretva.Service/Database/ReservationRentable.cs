using System;
using System.Collections.Generic;

namespace RS2_Camping_Neretva.Service.Database;

public partial class ReservationRentable
{
    public int ReservationId { get; set; }

    public int ItemId { get; set; }

    public int? Quantity { get; set; }

    public virtual RentableItem Item { get; set; } = null!;

    public virtual Reservation Reservation { get; set; } = null!;
}
