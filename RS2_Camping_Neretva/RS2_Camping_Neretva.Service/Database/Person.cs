using System;
using System.Collections.Generic;

namespace RS2_Camping_Neretva.Service.Database;

public partial class Person
{
    public int PersonId { get; set; }

    public string? Type { get; set; }

    public decimal? PricePerNight { get; set; }

    public virtual ICollection<ReservationPerson> ReservationPeople { get; set; } = new List<ReservationPerson>();
}
