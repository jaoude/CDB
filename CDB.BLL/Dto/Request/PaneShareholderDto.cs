using System;
using System.Collections.Generic;
using System.Text;

namespace CDB.BLL.Dto.Request
{
    public class PaneShareholderDto
    {
        public int CompanyId { get; set; }
        public List<ShareholderDto> Shareholders { get; set; }
    }
}