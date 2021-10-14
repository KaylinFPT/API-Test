﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Test.Models
{
    public class Booking
    {

        [Key]
        public int Id { get; set; }

        [Required]
        //[Index(IsUnique = true)]
        [StringLength(10)]
        public string BookingRef { get; set; }

        [Required]
        [Display(Name = "Booking Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Transporter ")]
        public int TransporterId { get; set; }

       


        [Required]
        [RegularExpression(@"^(?![\W_]+$)(?!\d+$)[a-zA-Z0-9]+$", ErrorMessage = "Please enter a valid Registration(remove spaces & special characters if any).")]
        //[RegularExpression(@"[^\s]+", ErrorMessage = "Please remove spaces.")]
        public string Registration { get; set; }


        [Display(Name = "Trailer Reg ")]
        //[RegularExpression(@"[^\s]+", ErrorMessage = "Please remove spaces.")]
        [RegularExpression(@"^(?![\W_]+$)(?!\d+$)[a-zA-Z0-9]+$", ErrorMessage = "Please enter a valid Registration(remove spaces & special characters if any).")]
        public string TrailerReg { get; set; }


        [Required]
        [Display(Name = "Warehouse ")]
        public int WarehouseId { get; set; }




        [Required]
        [Display(Name = "Exporter ")]
        public int ExporterId { get; set; }

       
 

        [Required]
        [RegularExpression(@"^[a-zA-Z ']+$", ErrorMessage = "Use letters only please")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Market Type  ")]
        public int MarketTypeId { get; set; }


        [Required]
        [Display(Name = "Phone No. ")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Time (Hour - 24Hr) ")]
        public int RowIndex { get; set; }

        [Required]
        [Display(Name = "Status ")]
        public string Status { get; set; }

        [Required]
        [Display(Name = "Created On")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDateUtc { get; set; }

        public Boolean IsLate { get; set; }

        public Boolean IsEarly { get; set; }

        [Display(Name = "TruckStop Arrival")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime TsArr { get; set; }

        [Display(Name = "TruckStop Departure")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime TsDep { get; set; }

        [Display(Name = "Gate In")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime GIn { get; set; }

        [Display(Name = "Gate Out")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime GOut { get; set; }


        [Display(Name = "TruckStop Duration")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm\\:ss}", ApplyFormatInEditMode = true)]
        public string TsDur { get; set; }

        [Display(Name = "TruckStop To Warehouse Duration")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm\\:ss}", ApplyFormatInEditMode = true)]
        public string TsToWhDur { get; set; }

        [Display(Name = "Warehouse Duration")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm\\:ss}", ApplyFormatInEditMode = true)]
        public string WhDur { get; set; }

        [Display(Name = "TBRN")]

        public int TBRN { get; set; }

        public string UserTruckStop { get; set; }

        public string UserWarehouse { get; set; }

        public Booking()
        {
            this.CreatedDateUtc = DateTime.Now;
            this.IsLate = false;
            this.IsEarly = false;
        }

    }
}
