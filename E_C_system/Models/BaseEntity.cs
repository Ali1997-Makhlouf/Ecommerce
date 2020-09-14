using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_C_system.Models
{
    public class BaseEntity
    {


        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        [Display(Name = "Created At")]
        [DataType(DataType.DateTime)]
        public DateTime? CreatedAt { get; set; }

        [Display(Name = "Modified By")]

        public string ModifiedBy { get; set; }

        [Display(Name = "Modified At")]
        [DataType(DataType.DateTime)]
        public DateTime? ModifiedAt { get; set; }

        [Display(Name = "Deleted By")]

        public string DeletedBy { get; set; }

        [Display(Name = "Deleted At")]
        [DataType(DataType.DateTime)]
        public DateTime? DeletedAt { get; set; }

        [Display(Name = "Is Active")]

        public bool? IsActive { get; set; }
        [Display(Name = "Is Deleted")]

        public bool? IsDeleted { get; set; }

        [Display(Name = "Additional Notes")]
        public string AdminNote { get; set; }
    }
}
