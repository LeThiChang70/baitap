using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeThiChang070.Models
{
    public class LTC070
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string LTCID { get; set; }
        [StringLength(50)]
        public string LTCName { get; set; }
        public Boolean LTCGender { get; set; }
    }
}
