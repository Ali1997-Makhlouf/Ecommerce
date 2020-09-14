using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_C_system.Models
{
    public class Session : BaseEntity
    {
        [Key]
        public Guid Session_ID { get; set; }
        public string ClientID { get; set; }
        public string User_IP { get; set; }
        public string User_Mac { get; set; }
        public string Session_Data { get; set; }
        //________________________________________________
        public virtual ICollection<Order> Orders { get; set; }
        public virtual Client Client { get; set; }


    }
}
