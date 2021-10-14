using System;
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

        public string BookingRef { get; set; }

        public DateTime Date { get; set; }

        public int TransporterId { get; set; }

        public string Registration { get; set; }


        public string TrailerReg { get; set; }


        public int WarehouseId { get; set; }

        public int ExporterId { get; set; }

        public string Name { get; set; }

        public int MarketTypeId { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int RowIndex { get; set; }

        public string Status { get; set; }

        public DateTime CreatedDateUtc { get; set; }

        public Boolean IsLate { get; set; }

        public Boolean IsEarly { get; set; }

        public DateTime TsArr { get; set; }

        public DateTime TsDep { get; set; }

        public DateTime GIn { get; set; }

        public DateTime GOut { get; set; }


        public string TsDur { get; set; }

        public string TsToWhDur { get; set; }

        public string WhDur { get; set; }

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
