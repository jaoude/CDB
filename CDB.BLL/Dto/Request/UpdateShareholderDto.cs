using CDB.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

namespace CDB.BLL.Dto.Request
{
    public class UpdateShareholderDto
    {
        [Display(Name = Constants.DISPLAY_FULL_NAME
            + Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_FULL_NAME_AR)]
        [MaxLength(Constants.FULL_NAME_CHAR_LENGHT)]
        public string FullName { get; set; }

        [Display(Name = Constants.DISPLAY_PHONE_NUMBER
            + Constants.DISPLAY_NAME_SEPARATOR
            + Constants.DISPLAY_PHONE_NUMBER_AR)]
        [MaxLength(Constants.PHONE_NUMBER_CHAR_LENGTH)]
        public string PhoneNumber { get; set; }

        [Display(Name = Constants.DISPLAY_SHARE_CONTRIBUTION
          + Constants.DISPLAY_NAME_SEPARATOR
          + Constants.DISPLAY_SHARE_CONTRIBUTION_AR)]
        public int ShareContribution { get; set; }

        [Display(Name = Constants.DISPLAY_FINANCIAL_NUMBER
           + Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_FINANCIAL_NUMBER_AR)]
        [MaxLength(Constants.FINANCIAL_NUMBER_CHAR_LENGTH)]
        public string FinancialNumber { get; set; }

        [Display(Name = Constants.DISPLAY_PLACE_DATE_BIRTH
           + Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_PLACE_DATE_BIRTH_AR)]
        [MaxLength(Constants.PLACE_DATE_BIRTH_CHAR_LENGTH)]
        public string PlaceAndDateOfBirth { get; set; }

        [Display(Name = Constants.DISPLAY_NATIONALITY
           + Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_NATIONALITY_AR)]
        [MaxLength(Constants.NATIONALITY_CHAR_LENGTH)]
        public string Nationality { get; set; }

        [Display(Name = Constants.DISPLAY_PROCURATOR_NAME
           + Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_PROCURATOR_NAME_AR)]
        [MaxLength(Constants.FULL_NAME_CHAR_LENGHT)]
        public string ProcuratorName { get; set; }

        [Display(Name = Constants.DISPLAY_SIGNING_PERSONALLY
           + Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_SIGNING_PERSONALLY_AR)]
        public bool SigningPersonally { get; set; }

        [Display(Name = Constants.DISPLAY_SIGNING_THROUGH
           + Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_SIGNING_THROUGH_AR)]
        public bool SigningThrough { get; set; }

        [Display(Name = Constants.DISPLAY_SHAREHOLDER_ID_ATTACHED
           + Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_SHAREHOLDER_ID_ATTACHED_AR)]
        public bool ShareHolderIdAttached { get; set; }

        [Display(Name = Constants.DISPLAY_PROCURATION_ATTACHED
           + Constants.DISPLAY_NAME_SEPARATOR
           + Constants.DISPLAY_PROCURATION_ATTACHED_AR)]
        public bool ProcurationAttached { get; set; }

        public UpdateAddressDto ShareholderAddress { get; set; }
    }
}
