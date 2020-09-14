using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_C_system.Models
{
    public class OrderProduct : BaseEntity
    {
        [Key]
        public Guid OrderProduct_ID { get; set; }
        public Guid OrderID { get; set; }
        public Guid ProductID { get; set; }
        public int Product_Quantity { get; set; }
        public int Subtotal { get; set; }
        //_________________________________________
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
