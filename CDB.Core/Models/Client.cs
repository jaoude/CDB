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

        [MaxLength(Constants.ClientIdCharLength)]
        public string ClientId { get; set; }

        [MaxLength(Constants.CompanyNameCharLength)]
        public string CompanyName { get; set; }

        [MaxLength(Constants.CompanyNameCharLength)]
        public string ArabicCompanyName { get; set; }


        public short CompanyType { get; set; }
    }
}
