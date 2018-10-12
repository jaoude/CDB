using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace CDB.BLL.Dto.Response
{
    public class ClientDto
    {
        public int Id { get; set; }

        public string ClientId { get; set; }

        public string CompanyName { get; set; }

        public string ArabicCompanyName { get; set; }

        public byte CompanyType { get; set; }

        public string RegistPlaceNumb { get; set; }

        public DateTime EstablishDate { get; set; }

        public string PhoneNbre { get; set; }

        public bool Ownership { get; set; }

        public bool OccupationPermit { get; set; }

        public bool RealEstateCertificate { get; set; }

        public float CapitalAmount { get; set; }

        public float TotalShares { get; set; }

        public byte BankName { get; set; }

        public string FinancialAuditorName { get; set; }

        public TimeSpan WorkDuration { get; set; }

        public bool DocsAttached { get; set; }

        public bool Activity { get; set; }

        public string AuthorizedSignature { get; set; }

        public string ShareHoldersName { get; set; }

        public string ShareHoldersPhoneNbre { get; set; }

        public float ShareHoldersContribution { get; set; }

        public string ShareHoldersPosition { get; set; }

        
        
    }
}
