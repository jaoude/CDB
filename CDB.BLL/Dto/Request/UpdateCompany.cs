using CDB.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

namespace CDB.BLL.Dto.Request
{
    public class UpdateCompany
    {
        [Required]
        [MaxLength(Constants.COMPANY_ID_CHAR_LENGTH)]
        [Display(Name = Constants.DISPLAY_COMPANY_ID_ENGLISH
            + Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_COMPANY_ID_ENGLISH_AR)]
        public string CompanyId { get; set; }

        [Required]
        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        [Display(Name = Constants.DISPLAY_COMPANY_NAME_ENGLISH
            + Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_COMPANY_NAME_ENGLISH_AR)]
        public string CompanyName { get; set; }

        [Required]
        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        [Display(Name = Constants.DISPLAY_COMPANY_NAME_ARABIC
            + Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_COMPANY_NAME_ARABIC_AR)]
        public string ArabicCompanyName { get; set; }

        [Display(Name = Constants.DISPLAY_COMPANY_TYPE
            + Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_COMPANY_TYPE_AR)]
        public byte CompanyType { get; set; }

        [Required]
        public byte District { get; set; }

        [Required]
        public byte Kaza { get; set; }

        [MaxLength(Constants.ADDRESS_CITY_CHAR_LENGTH)]
        public string City { get; set; }

        [MaxLength(Constants.ADDRESS_ROAD_CHAR_LENGTH)]
        public string Road { get; set; }

        [MaxLength(Constants.ADDRESS_BUILDING_CHAR_LENGTH)]
        public string Building { get; set; }

        [MaxLength(Constants.ADDRESS_FLOOR_CHAR_LENGTH)]
        public string Floor { get; set; }

        [Required]
        [MaxLength(Constants.FULL_NAME_CHAR_LENGHT)]
        [Display(Name = Constants.DISPLAY_LAWYER_NAME +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_LAWYER_NAME_AR)]
        public string LawyerName { get; set; }



        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        [Display(Name = Constants.DISPLAY_DOCUMENTS_ATTACHED +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_DOCUMENTS_ATTACHED_AR)]
        public string DocsAttached { get; set; }

        [Required]
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.SettingsBindable(true)]
        [Display(Name = Constants.DISPLAY_LAWYER_ID_ATTACHED +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_LAWYER_ID_ATTACHED_AR)]
        public bool LawyerId { get; set; }

        [Required]
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.SettingsBindable(true)]
        [Display(Name = Constants.DISPLAY_LAWYER_AUTHORIZATION_ATTACHED +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_LAWYER_AUTHORIZATION_ATTACHED_AR)]
        public bool LawyerAuthorization { get; set; }


        [Required]
        [MaxLength(Constants.FULL_NAME_CHAR_LENGHT)]
        [Display(Name = Constants.DISPLAY_FINANCIAL_AUDITOR_NAME +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_FINANCIAL_AUDITOR_NAME_AR)]
        public string FinancialAuditorName { get; set; }





        [Required]
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.SettingsBindable(true)]
        [Display(Name = Constants.DISPLAY_FINANCIAL_AUDITOR_APPROVAL_ATTACHED +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_FINANCIAL_AUDITOR_APPROVAL_ATTACHED_AR)]
        public bool FinancialAuditorApproval { get; set; }

        [Required]
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.SettingsBindable(true)]
        [Display(Name = Constants.DISPLAY_FINANCIAL_AUDITOR_PROFESSION_ATTACHED +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_FINANCIAL_AUDITOR_PROFESSION_ATTACHED_AR)]
        public bool FinancialAuditorProfession { get; set; }



    }
}
