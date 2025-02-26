using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2_Camping_Neretva.Service.Database
{
    public partial class Role
    {
        public int RoleId { get; set; }
        public string? RoleName { get; set; }

        public virtual ICollection<Worker> Workers { get; set; } = new List<Worker>();
    }
}
