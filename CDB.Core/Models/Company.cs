using CDB.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CDB.Core.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(Constants.COMPANY_ID_CHAR_LENGTH)]
        public string CompanyId { get; set; }

        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        public string CompanyName { get; set; }

        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        public string ArabicCompanyName { get; set; }
        
        public byte CompanyType { get; set; }

        [ForeignKey("Address")]
        public int? AddressId { get; set; }
        public Address Address { get; set; }

        public ICollection<Shareholder> Shareholders { get; set; }



        [MaxLength(Constants.FULL_NAME_CHAR_LENGHT)]
        public string LawyerName { get; set; }
        public bool LawyerId { get; set; }
        public bool LawyerAuthorization { get; set; }

        [MaxLength(Constants.FULL_NAME_CHAR_LENGHT)]
        public string Auditor { get; set; }
        public bool AuditorApproval { get; set; }
        public bool AuditorProfession { get; set; }

        public ICollection<Document> Documents { get; set; }

    }
}
