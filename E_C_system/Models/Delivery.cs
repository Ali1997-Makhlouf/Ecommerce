using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_C_system.Models
{
    public class Delivery : BaseEntity
    {
        [Key]
        public Guid DeliveryID { get; set; }
        public Guid AddressID { get; set; }
        public string ClientID { get; set; }
        public string Delivery_Status { get; set; }
        public string Delivery_Note { get; set; }
        public Guid OrderID { get; set; }


        //________________________________________________

        public virtual Order Order { get; set; }

        public virtual Client Client { get; set; }

    }
}
