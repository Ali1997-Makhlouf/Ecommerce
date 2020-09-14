using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_C_system.Models
{
    public class Offer : BaseEntity
    {
        [Key]
        public Guid Offer_ID { get; set; }
        public string Offer_Name { get; set; }
        public int Offer_Percent { get; set; }
        public string Offer_Description { get; set; }
        public DateTime Offer_Start_Date { get; set; }
        public DateTime Offer_End_Date { get; set; }
        //_________________________________________________

        public virtual ICollection<ProductOffer> ProductOffers { get; set; }
    }
}
