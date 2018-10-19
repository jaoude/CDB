using CDB.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CDB.Core.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        
        //public int CompanyId { get; set; } 

        //public int ShareHolderId { get; set; } 

        public byte Kaza { get; set; }

        public byte District { get; set; }

        [MaxLength(Constants.ADDRESS_CITY_CHAR_LENGTH)]
        public string City { get; set; }
       
        [MaxLength(Constants.ADDRESS_ROAD_CHAR_LENGTH)]
        public string Road { get; set; } 

        [MaxLength(Constants.ADDRESS_BUILDING_CHAR_LENGTH)]
        public string Building { get; set; } 

        [MaxLength(Constants.ADDRESS_FLOOR_CHAR_LENGTH)]
        public string Floor { get; set; } 
    }
}
