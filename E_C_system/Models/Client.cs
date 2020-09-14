using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_C_system.Models
{
    public class Client : IdentityUser
    {
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<Delivery> Deliveries { get; set; }
    }
}
