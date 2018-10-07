using CDB.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDB.Core.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(Constants.CLIENT_ID_CHAR_LENGTH)]
        public string ClientId { get; set; }

        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        public string CompanyName { get; set; }

        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        public string ArabicCompanyName { get; set; }


        public short CompanyType { get; set; }
    }
}
