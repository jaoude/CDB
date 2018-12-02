using CDB.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CDB.Core.Models
{
    public class Shareholder
    {

        [Key]
        public int Id { get; set; }

        [MaxLength(Constants.FULL_NAME_CHAR_LENGHT)]
        public string FullName { get; set; }

        [MaxLength(Constants.PHONE_NUMBER_CHAR_LENGTH)]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "decimal(19, 4)")]
        public decimal ShareContribution { get; set; }

        [MaxLength(Constants.FINANCIAL_NUMBER_CHAR_LENGTH)]
        public string FinancialNumber { get; set; }

        [MaxLength(Constants.PLACE_DATE_BIRTH_CHAR_LENGTH)]
        public string PlaceAndDateOfBirth { get; set; }

        [MaxLength(Constants.NATIONALITY_CHAR_LENGTH)]
        public string Nationality { get; set; }

        [MaxLength(Constants.FULL_NAME_CHAR_LENGHT)]
        public string ProcuratorName { get; set;}

        public byte SigningThrough { get; set; }

        public bool ShareHolderIdAttached { get; set; }

        public bool ProcurationAttached { get; set; }

        public int? AddressId { get; set; }
        public Address Address { get; set; }

        public Company Company { get; set; }
        public int CompanyId { get; set; }

    }
}
