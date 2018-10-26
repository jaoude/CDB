using CDB.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CDB.Core.Models
{
    public class Document
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public byte CategoryId { get; set; }

        public byte SubCategoryId { get; set; }

        public DateTime UploadedOn { get; set; }
        
        public string Name { get; set; }
    }
}
