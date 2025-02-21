using System;
using System.Collections.Generic;

namespace RS2_Camping_Neretva.Service.Database;

public partial class Accommodation
{
    public int AccommodationId { get; set; }

    public string? Type { get; set; }

    public decimal? PricePerNight { get; set; }

    public virtual ICollection<ReservationAccommodation> ReservationAccommodations { get; set; } = new List<ReservationAccommodation>();
}
