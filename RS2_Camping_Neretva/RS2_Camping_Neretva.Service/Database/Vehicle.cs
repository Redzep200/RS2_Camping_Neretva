using System;
using System.Collections.Generic;

namespace RS2_Camping_Neretva.Service.Database;

public partial class Vehicle
{
    public int VehicleId { get; set; }

    public string? Type { get; set; }

    public decimal? PricePerNight { get; set; }

    public virtual ICollection<ReservationVehicle> ReservationVehicles { get; set; } = new List<ReservationVehicle>();
}
