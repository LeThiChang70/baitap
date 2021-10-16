using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeThiChang070.Models
{
    public class PersonLTC070
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string PersonID { get; set; }
        [Required]
        [StringLength(50)]
        public string PersonName { get; set; }
    }
}
