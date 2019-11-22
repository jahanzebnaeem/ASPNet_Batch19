using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCModelInto.Models
{
    public class Country
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(4)]
        public string Name { get; set; }
        public virtual List<City> Cities { get; set; }
    }
}