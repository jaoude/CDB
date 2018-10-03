using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CDB.Core.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        
        public short? Kaza { get; set; }
        
        public string City { get; set; }
    }
}
