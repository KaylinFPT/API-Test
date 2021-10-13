using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Test.Models
{
    public class Exporter
    {
        public int Id { get; set; }

        public string KeyCode { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public Boolean EmailActive { get; set; }

        public Boolean IsActive { get; set; }

        public Exporter()
        {
            this.IsActive = true;
            this.EmailActive = false;

        }


    }
}
