using System;
using System.Collections.Generic;
using System.Text;

namespace CDB.BLL.Dto.Response
{
    public class ClientDto
    {
        public int Id { get; set; }

        public string ClientId { get; set; }

        public string CompanyName { get; set; }

        public string ArabicCompanyName { get; set; }

        public byte CompanyType { get; set; }
    }
}
