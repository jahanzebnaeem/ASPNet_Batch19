using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCModelInto.Models
{
    public class City
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(4)]
        public String Name { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
    }
}