using CDB.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDB.BLL.Dto.Request
{
    public class DocumentDto
    {
        public int Id { get; set; }

        [Required]
        public int CompnayId { get; set; }
        
        [Required]
        public byte CategoryId { get; set; }

        [Required]
        public byte SubCategoryId { get; set; }

        [Required]
        public DateTime UploadedOn { get; set; }

        [Required]
        [MaxLength(Constants.DOCUMENT_NAME_CHAR_LENGTH)]
        public string Name { get; set; }
    }
}
