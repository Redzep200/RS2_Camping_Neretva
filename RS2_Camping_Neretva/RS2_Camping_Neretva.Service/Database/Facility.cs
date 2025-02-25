using System;
using System.Collections.Generic;

namespace RS2_Camping_Neretva.Service.Database;

public partial class Facility
{
    public int FacilityId { get; set; }

    public string? FacilityType { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();
}
