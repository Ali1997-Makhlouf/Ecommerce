using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_C_system.Models
{
    public class ProductOffer
    {
        [Key]
        public Guid ProductOffer_ID { get; set; }
        public Guid OfferID { get; set; }
        public Guid ProductID { get; set; }
        //_______________________________________
        public virtual Offer Offer { get; set; }
        public virtual Product Product { get; set; }

    }
}
