using System;
using System.Collections.Generic;
using System.Text;

namespace CDB.BLL.Dto.Request
{
    public class DocumentPaneDto
    {
        public int CompanyId { get; set; }
        public List<DocumentDto> Documents { get; set; }
    }
}
