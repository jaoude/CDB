using CDB.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

namespace CDB.BLL.Dto.Request
{
    public class UpdateFinancialAuditorDto
    {
        //[Required]
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

        //[Required]
        [Display(Name = Constants.DISPLAY_FINANCIAL_AUDITOR_APPROVAL_ATTACHED +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_FINANCIAL_AUDITOR_APPROVAL_ATTACHED_AR)]
        public bool FinancialAuditorApproval { get; set; }

        //[Required]
        [Display(Name = Constants.DISPLAY_FINANCIAL_AUDITOR_PROFESSION_ATTACHED +
           Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_FINANCIAL_AUDITOR_PROFESSION_ATTACHED_AR)]
        public bool FinancialAuditorProfession { get; set; }
    }

}
