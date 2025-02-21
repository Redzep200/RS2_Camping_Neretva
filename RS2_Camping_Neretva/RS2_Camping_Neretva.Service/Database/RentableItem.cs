﻿using System;
using System.Collections.Generic;

namespace RS2_Camping_Neretva.Service.Database;

public partial class RentableItem
{
    public int ItemId { get; set; }

    public int? TotalQuantity { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? PricePerDay { get; set; }

    public string? AvailabilityStatus { get; set; }

    public virtual ICollection<ReservationRentable> ReservationRentables { get; set; } = new List<ReservationRentable>();
}
