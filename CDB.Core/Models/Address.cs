using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDB.Core.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public byte district { get; set; }

        public string City { get; set; }

        public string CityRoad { get; set; }

        public string BldgFloor { get; set; }


    }
}
