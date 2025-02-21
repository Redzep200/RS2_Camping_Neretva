using System;
using System.Collections.Generic;
using System.Text;

namespace RS2_Camping_Neretva.Model
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserType { get; set; }
    }
}
