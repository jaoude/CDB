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
    }

    }
