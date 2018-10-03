using CDB.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDB.BLL.Dto.Request
{
    public class CreateClientDto
    {
        [Required]
        public string ClientId { get; set; }

        [Required]
        [MaxLength(Constants.CompanyNameCharLength)]
        public string CompanyName { get; set; }

        [Required]
        [MaxLength(Constants.CompanyNameCharLength)]
        public string ArabicCompanyName { get; set; }

        [Required]
        public byte CompanyType{ get; set; }
    }    
}
