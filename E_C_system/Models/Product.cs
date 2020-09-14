using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_C_system.Models
{
    public class Product:BaseEntity
    {
        [Key]
        public Guid Product_ID { get; set; }
        public Guid CategoryID { get; set; }
        public string  Product_Name { get; set; }
        public string Product_Photo { get; set; }
        public string Product_Description { get; set; }
        public string  Product_Details { get; set; }
        public double Product_Price { get; set; }
        public int Product_Quantity { get; set; }
        public double Product_Tax { get; set; }

        //______________________________________________________________________

        public virtual Category Category { get; set; }
        public virtual ICollection<ProductOffer> ProductOffers { get; set; }
        public virtual ICollection<ProductPhoto> ProductPhotos { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

    }
}
