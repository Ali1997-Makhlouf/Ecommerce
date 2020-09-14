using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_C_system.Models
{
    public class Address : BaseEntity
    {
        [Key]
        public Guid Address_ID { get; set; }
        public string ClientID { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Building_Number { get; set; }
        public int Postal_Code { get; set; }
        //____________________________________________
        public virtual Client client { get; set; }
        public virtual ICollection<Order> Orders { get; set; }


    }
}
