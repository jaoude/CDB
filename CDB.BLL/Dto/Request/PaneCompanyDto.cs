using System;
using System.Collections.Generic;
using System.Text;

namespace CDB.BLL.Dto.Request
{
    public class PaneCompanyDto
    {
        public int CompanyId { get; set; }
        public CreateCompanyDto Company { get; set; }
        public AddressDto Address { get; set; }
    }
}
