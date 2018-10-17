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

        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        public string AddressCompany { get; set; }

        public byte AdressKaza { get; set; }

        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        public string AddressCity { get; set; }

        public byte AdressGovernate { get; set; }


        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        public string AddressBldg { get; set; }
    }
}
