using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Test.Models
{
    public class Slots
    {
        public int Id { get; set; }

        [Display(Name = "Date ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Warehouse ")]
        public int WarehouseId { get; set; }

        [Required]
        [Display(Name = "Start Time (24-Hour Time Format ) ")]
        public int StartTime { get; set; }

        [Required]
        [Display(Name = "End Time (24-Hour Time Format )")]
        public int EndTime { get; set; }
    }
}
