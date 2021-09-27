using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Test.Models
{
    public class Transporter
    {
        public int Id { get; set; }

        [Display(Name = "Key Code")]
        [Required]
        public string KeyCode { get; set; }

        [Display(Name = "Transporter")]
        [Required]
        public string Name { get; set; }
    }
}
