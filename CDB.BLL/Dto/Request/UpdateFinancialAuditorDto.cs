using CDB.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

namespace CDB.BLL.Dto.Request
{
    public class UpdateFinancialAuditorDto
    {
        [Required]
        [MaxLength(Constants.FULL_NAME_CHAR_LENGHT)]
        [Display(Name = Constants.DISPLAY_FINANCIAL_AUDITOR_NAME +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_FINANCIAL_AUDITOR_NAME_AR)]
        public string FinancialAuditorName { get; set; }

        

        [MaxLength(Constants.COMPANY_NAME_CHAR_LENGTH)]
        [Display(Name = Constants.DISPLAY_DOCUMENTS_ATTACHED +
            Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_DOCUMENTS_ATTACHED_AR)]
        public string DocsAttached { get; set; }

        [Required]
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.SettingsBindable(true)]
        [Display(Name = Constants.DISPLAY_DOCUMENTS3_ATTACHED +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_DOCUMENTS3_ATTACHED_AR)]
        public bool Docs3Attached { get; set; }

        [Required]
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.SettingsBindable(true)]
        [Display(Name = Constants.DISPLAY_DOCUMENTS4_ATTACHED +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_DOCUMENTS4_ATTACHED_AR)]
        public bool Docs4Attached { get; set; }
    }

}
