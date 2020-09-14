using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_C_system.Models
{
    public class Category : BaseEntity
    {
        [Key]
        public Guid Category_ID { get; set; }
        public string Category_Name { get; set; }
        public Guid? ParentId { get; set; }
        //_____________________________________________________________________________________
        public virtual ICollection<Product> Products { get; set; }
        public virtual Category Parent{ get; set; }
        public virtual ICollection<Category> Children { get; set; }

        

    }
}