using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_C_system.Models
{
    public class Order : BaseEntity
    {
        [Key]
        public Guid OrderID { get; set; }
        public Guid SessionID { get; set; }
        public string ClientID { get; set; }
        public Guid AddressID { get; set; }
        public Guid AddressID2 { get; set; }
        public string Order_Payment_Status { get; set; }

        public string Order_Payment_Type { get; set; }

        public double Order_Total { get; set; }


        //__________________________________________________
        public virtual ICollection<OrderProduct> orderProducts { get; set; }
        public virtual Session session { get; set; }
        public virtual Client Client { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Delivery> Deliveries { get; set; }


    }
}
