using CDB.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

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
        [Display(Name = Constants.DISPLAY_COMPANY_TYPE +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_COMPANY_TYPE_AR)]
        public byte CompanyType { get; set; }

        public SelectList CompanyTypes { get; set; }

       
        public byte Bank { get; set; }

        public SelectList Banks { get; set; }

        [Required]
        [MaxLength(Constants.REGISTRATION_PLACE_CHAR_LENGTH)]
        public string RegistPlaceNumb { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EstablishDate { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNbre { get; set; }

        [Required]
        [Range(typeof(bool), "false", "true")]
        public bool Ownership { get; set; }

        [Required]
        [Range(typeof(bool), "false", "true")]
        public bool OccupationPermit { get; set; }

        [Required]
        [Range(typeof(bool), "false", "true")]
        public bool RealEstateCertificate { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public float CapitalAmount { get; set; }

        [Required]
        public float TotalShares { get; set; }

        [Required]
        [MaxLength(Constants.FINANCIAL_AUDITOR_NAME_CHAR_LENGHT)]
        public string FinancialAuditorName { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan WorkDuration { get; set; }

        [Required]
        [Range(typeof(bool), "false", "true")]
        public bool DocsAttached { get; set; }

        [Required]
        [Range(typeof(bool), "false", "true")]
        public bool Activity { get; set; }

        [Required]
        [MaxLength(Constants.AUTHORIZED_SIGNATURE_CHAR_LENGHT)]
        public string AuthorizedSignature { get; set; }

        [Required]
        [MaxLength(Constants.SHAREHOLDERS_NAME_CHAR_LENGHT)]
        public string ShareHoldersName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ShareHoldersPhoneNbre { get; set; }

        [Required]
        public float ShareHoldersContribution { get; set; }

        [Required]
        [MaxLength(Constants.AUTHORIZED_SIGNATURE_CHAR_LENGHT)]
        public string ShareHoldersPosition { get; set; }
    }    
}
