using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_C_system.Models
{
    public class ProductPhoto
    {
        [Key]
        public Guid Photo_ID { get; set; }
        public Guid ProductID { get; set; }

        public string Photo_Name { get; set; }
        //_____________________________________________________
        public virtual Product Product { get; set; }

    }
}
