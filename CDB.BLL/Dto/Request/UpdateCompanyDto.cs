using CDB.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CDB.BLL.Dto.Request
{
    public class UpdateCompanyDto
    {
        public CompanyPaneDto CompanyPane { get; set; }

        public ShareholderPaneDto ShareholderPane { get; set; }

        public DocumentPaneDto DocumentPane { get; set; }
    }

    public class CompanyPaneDto
    {
        public int CompanyId { get; set; }
        public CreateCompanyDto Company { get; set; }
        public UpdateAddressDto Address { get; set; }
        public UpdateLawyerDto Lawyer { get; set; }

        //[MaxLength(Constants.FULL_NAME_CHAR_LENGHT)]
        //[Display(Name = Constants.DISPLAY_LAWYER_NAME +
        //    Constants.DISPLAY_NAME_SEPARATOR
        //    + Constants.DISPLAY_LAWYER_NAME_AR)]
        // public string LawyerName { get; set; }
    }


    public class ShareholderPaneDto
    {
        public int CompanyId { get; set; }
        public List<UpdateShareholderDto> Shareholders { get; set; }
    }

    public class DocumentPaneDto
    {
        public int CompanyId { get; set; }

    }
}
