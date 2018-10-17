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

        [MaxLength(Constants.PHONE_NUMBER_CHAR_LENGTH)]
        public string PhoneNbre { get; set; }

        [Range(typeof(bool), "false", "true")]
        public bool Ownership { get; set; }

        [Range(typeof(bool), "false", "true")]
        public bool OccupationPermit { get; set; }

        [Range(typeof(bool), "false", "true")]
        public bool OccupationDeed { get; set; }

        [Range(typeof(bool), "false", "true")]
        public bool Rental { get; set; }

        [Range(typeof(bool), "false", "true")]
        public bool RealEstateCertificate { get; set; }

        [Column(TypeName = "decimal(19, 4)")]
        public decimal CapitalAmount { get; set; }

        public int TotalShares { get; set; }

        
        public byte Bank { get; set; }

        [MaxLength(Constants.FINANCIAL_AUDITOR_NAME_CHAR_LENGHT)]
        public string FinancialAuditorName { get; set; }

        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        public string WorkDuration { get; set; }

        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        public string DocsAttached { get; set; }

        [Range(typeof(bool), "false", "true")]
        public bool Docs1Attached { get; set; }

        [Range(typeof(bool), "false", "true")]
        public bool Docs2Attached { get; set; }

        [MaxLength(Constants.SHAREHOLDERS_NAME_CHAR_LENGHT)]
        public string LawyerName { get; set; }

        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        public string Activity { get; set; }

        [Range(typeof(bool), "false", "true")]
        public bool Activity1 { get; set; }

        [Range(typeof(bool), "false", "true")]
        public bool Activity2 { get; set; }

        [Range(typeof(bool), "false", "true")]
        public bool Activity3 { get; set; }

        [Range(typeof(bool), "false", "true")]
        public bool Activity4 { get; set; }

        [Range(typeof(bool), "false", "true")]
        public bool Activity5 { get; set; }

        [Range(typeof(bool), "false", "true")]
        public bool Activity6 { get; set; }

        [Range(typeof(bool), "false", "true")]
        public bool Activity7 { get; set; }


        [MaxLength(Constants.AUTHORIZED_SIGNATURE_CHAR_LENGHT)]
        public string AuthorizedSignature { get; set; }

        [MaxLength(Constants.SHAREHOLDERS_NAME_CHAR_LENGHT)]
        public string ShareHoldersName { get; set; }

        [MaxLength(Constants.PHONE_NUMBER_CHAR_LENGTH)]
        public string ShareHoldersPhoneNbre { get; set; }


        public float ShareHoldersContribution { get; set; }

        [MaxLength(Constants.AUTHORIZED_SIGNATURE_CHAR_LENGHT)]
        public string ShareHoldersPosition { get; set; }

    }
}
