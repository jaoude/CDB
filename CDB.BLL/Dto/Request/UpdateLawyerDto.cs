using CDB.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

namespace CDB.BLL.Dto.Request
{
    public class UpdateLawyerDto
    {
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
    }

    }
