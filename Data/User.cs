﻿using Microsoft.AspNetCore.Identity;

namespace FleksProject.Data
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
