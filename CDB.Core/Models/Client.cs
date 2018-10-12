using CDB.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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


        public byte CompanyType { get; set; }

        [MaxLength(Constants.REGISTRATION_PLACE_CHAR_LENGTH)]
        public string RegistPlaceNumb { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EstablishDate { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNbre { get; set; }

        [Range(typeof(bool), "true", "false")]
        public bool Ownership { get; set; }

        [Range(typeof(bool), "true", "false")]
        public bool OccupationPermit { get; set; }


        [Range(typeof(bool), "true", "false")]
        public bool RealEstateCertificate { get; set; }

        [Column(TypeName = "decimal(19, 4)")]
        public decimal CapitalAmount { get; set; }

        public int TotalShares { get; set; }

        
        public byte Bank { get; set; }

        [MaxLength(Constants.FINANCIAL_AUDITOR_NAME_CHAR_LENGHT)]
        public string FinancialAuditorName { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan WorkDuration { get; set; }

        [Range(typeof(bool), "true", "false")]
        public bool DocsAttached { get; set; }

        [Range(typeof(bool), "true", "false")]
        public bool Activity { get; set; }


        [MaxLength(Constants.AUTHORIZED_SIGNATURE_CHAR_LENGHT)]
        public string AuthorizedSignature { get; set; }

        [MaxLength(Constants.SHAREHOLDERS_NAME_CHAR_LENGHT)]
        public string ShareHoldersName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string ShareHoldersPhoneNbre { get; set; }


        public float ShareHoldersContribution { get; set; }

        [MaxLength(Constants.AUTHORIZED_SIGNATURE_CHAR_LENGHT)]
        public string ShareHoldersPosition { get; set; }

    }
}
