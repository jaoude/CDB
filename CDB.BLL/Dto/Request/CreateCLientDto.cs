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
        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        public string CompanyName { get; set; }

        [Required]
        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        [Display(Name = Constants.DISPLAY_COMPANY_NAME_ARABIC + 
            Constants.DISPLAY_NAME_SEPARATOR 
            + Constants.DISPLAY_COMPANY_NAME_ARABIC_AR)]
        public string ArabicCompanyName { get; set; }

        [Required]
        public byte CompanyType{ get; set; }
    }    
}
