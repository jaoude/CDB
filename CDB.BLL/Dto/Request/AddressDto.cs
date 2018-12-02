using CDB.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

namespace CDB.BLL.Dto.Request
{
    public class AddressDto
    {
        //[Required]
        public byte District { get; set; }

        //[Required]
        public byte Kaza { get; set; }

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
