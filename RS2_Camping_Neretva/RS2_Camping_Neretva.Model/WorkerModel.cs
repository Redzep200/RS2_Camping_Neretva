using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Camping_Neretva.Model
{
    public class WorkerModel
    {
        private RoleModel roleModel;
        public int WorkerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Roles { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
