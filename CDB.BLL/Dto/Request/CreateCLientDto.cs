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
        [Display(Name = Constants.DISPLAY_COMPANY_NAME_ENGLISH +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_COMPANY_NAME_ENGLISH_AR)]
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

        [Display(Name = Constants.DISPLAY_BANK +
            Constants.DISPLAY_NAME_SEPARATOR
                   + Constants.DISPLAY_BANK_AR)]
        public byte Bank { get; set; }

        public SelectList Banks { get; set; }

        [Required]
        [MaxLength(Constants.REGISTRATION_PLACE_CHAR_LENGTH)]
        [Display(Name = Constants.DISPLAY_REGIST_PLACE_NBRE +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_REGIST_PLACE_NBRE_AR)]
        public string RegistPlaceNumb { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = Constants.DISPLAY_ESTABLISHMENT_DATE +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_ESTABLISHMENT_DATE_AR)]
        public DateTime EstablishDate { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = Constants.DISPLAY_PHONE_NUMBER +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_PHONE_NUMBER_AR)]
        public string PhoneNbre { get; set; }

        [Required]
        [DataType(DataType.Html)]
        [Display(Name = Constants.DISPLAY_OWNERSHIP +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_OWNERSHIP_AR)]
        public bool Ownership { get; set; }

        [Required]
        [DataType(DataType.Html)]
        [Display(Name = Constants.DISPLAY_OCCUPATION_DEED +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_OCCUPATION_DEED_AR)]
        public bool OccupationDeed { get; set; }

        [Required]
        [DataType(DataType.Html)]
        [Display(Name = Constants.DISPLAY_RENTAL +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_RENTAL_AR)]
        public bool Rental { get; set; }

        [Required]
        [DataType(DataType.Html)]
        [Display(Name = Constants.DISPLAY_Occupation_Permit +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_Occupation_Permit_AR)]
        public bool OccupationPermit { get; set; }

        [Required]
        [DataType(DataType.Html)]
        [Display(Name = Constants.DISPLAY_REAL_ESTATE_CERTIFICATE +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_REAL_ESTATE_CERTIFICATE_AR)]
        public bool RealEstateCertificate { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = Constants.DISPLAY_CAPITAL_AMOUNT +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_CAPITAL_AMOUNT_AR)]
        public float CapitalAmount { get; set; }

        [Required]
        [Display(Name = Constants.DISPLAY_TOTAL_SHARES +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_TOTAL_SHARES_AR)]
        public float TotalShares { get; set; }

        [Required]
        [MaxLength(Constants.FINANCIAL_AUDITOR_NAME_CHAR_LENGHT)]
        [Display(Name = Constants.DISPLAY_FINANCIAL_AUDITOR_NAME +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_FINANCIAL_AUDITOR_NAME_AR)]
        public string FinancialAuditorName { get; set; }

        [Required]
        [DataType(DataType.Duration)]
        [Display(Name = Constants.DISPLAY_WORK_DURATION +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_WORK_DURATION_AR)]
        public string WorkDuration { get; set; }

        
        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        [Display(Name = Constants.DISPLAY_DOCUMENTS_ATTACHED +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_DOCUMENTS_ATTACHED_AR)]
        public string DocsAttached { get; set; }

        [Required]
        [DataType(DataType.Html)]
        [Display(Name = Constants.DISPLAY_DOCUMENTS1_ATTACHED +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_DOCUMENTS1_ATTACHED_AR)]
        public bool Docs1Attached { get; set; }

        [Required]
        [DataType(DataType.Html)]
        [Display(Name = Constants.DISPLAY_DOCUMENTS2_ATTACHED +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_DOCUMENTS2_ATTACHED_AR)]
        public bool Docs2Attached { get; set; }

        [Required]
        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        [Display(Name = Constants.DISPLAY_LAWYER_NAME +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_LAWYER_NAME_AR)]
        public string LawyerName { get; set; }

        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        [Display(Name = Constants.DISPLAY_ACTIVITY +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_ACTIVITY_AR)]
        public string Activity { get; set; }

        [Required]
        [DataType(DataType.Html)]
        [Display(Name = Constants.DISPLAY_ACTIVITY1 +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_ACTIVITY1_AR)]
        public bool Activity1 { get; set; }

        [Required]
        [DataType(DataType.Html)]
        [Display(Name = Constants.DISPLAY_ACTIVITY2 +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_ACTIVITY2_AR)]
        public bool Activity2 { get; set; }

        [Required]
        [DataType(DataType.Html)]
        [Display(Name = Constants.DISPLAY_ACTIVITY3 +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_ACTIVITY3_AR)]
        public bool Activity3 { get; set; }


        [Required]
        [DataType(DataType.Html)]
        [Display(Name = Constants.DISPLAY_ACTIVITY4 +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_ACTIVITY4_AR)]
        public bool Activity4 { get; set; }

        [Required]
        [DataType(DataType.Html)]
        [Display(Name = Constants.DISPLAY_ACTIVITY5 +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_ACTIVITY5_AR)]
        public bool Activity5 { get; set; }

        [Required]
        [DataType(DataType.Html)]
        [Display(Name = Constants.DISPLAY_ACTIVITY6 +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_ACTIVITY6_AR)]
        public bool Activity6 { get; set; }

        [Required]
        [DataType(DataType.Html)]
        [Display(Name = Constants.DISPLAY_ACTIVITY7 +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_ACTIVITY7_AR)]
        public bool Activity7 { get; set; }


        [Required]
        [MaxLength(Constants.AUTHORIZED_SIGNATURE_CHAR_LENGHT)]
        [Display(Name = Constants.DISPLAY_AUTHORIZED_SIGNATURE +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_Authorized_Signature_AR)]
        public string AuthorizedSignature { get; set; }

        [Required]
        [MaxLength(Constants.SHAREHOLDERS_NAME_CHAR_LENGHT)]
        [Display(Name = Constants.DISLPAY_SHAREHOLDERS_NAME +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_SHAREHOLDERS_NAME_AR)]
        public string ShareHoldersName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = Constants.DISPLAY_SHAREHOLDERS_PHONE_NUMBER +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_SHAREHOLDERS_PHONE_NUMBER_AR)]
        public string ShareHoldersPhoneNbre { get; set; }

        [Required]
        [Display(Name = Constants.DISPLAY_SHAREHOLDERS_CONTRIBUTION +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_SHAREHOLDERS_CONTRIBUTION_AR)]
        public float ShareHoldersContribution { get; set; }

        [Required]
        [MaxLength(Constants.AUTHORIZED_SIGNATURE_CHAR_LENGHT)]
        [Display(Name = Constants.DISPLAY_SHAREHOLDERS_POSITION +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_SHAREHOLDERS_POSITION_AR)]
        public string ShareHoldersPosition { get; set; }


        /*[MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        [Display(Name = Constants.DISPLAY_ADDRESS +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_ADDRESS_AR)]      
        public string AddressCompany { get; set; }


        [Required]
        [Display(Name = Constants.DISPLAY_ADDRESS_GOVERNATE +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_ADDRESS_GOVERNATE_AR)]
        public byte AddressGovernate { get; set; }

        public SelectList Governates { get; set; }

        [Display(Name = Constants.DISPLAY_ADDRESS_KAZA +
            Constants.DISPLAY_NAME_SEPARATOR
                   + Constants.DISPLAY_ADDRESS_KAZA_AR)]
        public byte AddressKaza { get; set; }

        public SelectList Kaza { get; set; }

        [Required]
        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        [Display(Name = Constants.DISPLAY_ADDRESS_CITY +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_ADDRESS_CITY_AR)]
        public string AddressCity { get; set; }

        [Required]
        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        [Display(Name = Constants.DISPLAY_ADDRESS_Bldg +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_ADDRESS_Bldg_AR)]
        public string AddressBldg { get; set; }*/





    }
}
