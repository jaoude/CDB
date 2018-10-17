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

        public double PhoneNbre { get; set; }

        public bool Ownership { get; set; }

        public bool Rental { get; set; }

        public bool OccupationDeed { get; set; }

        public bool OccupationPermit { get; set; }

        public bool RealEstateCertificate { get; set; }

        public float CapitalAmount { get; set; }

        public float TotalShares { get; set; }

        public byte Bank { get; set; }

        public string FinancialAuditorName { get; set; }

        public string WorkDuration { get; set; }

        public string DocsAttached { get; set; }

        public bool Docs1Attached { get; set; }

        public bool Docs2Attached { get; set; }

        public string Activity { get; set; }

        public bool Activity1 { get; set; }

        public bool Activity2 { get; set; }

        public bool Activity3 { get; set; }

        public bool Activity4 { get; set; }

        public bool Activity5 { get; set; }

        public bool Activity6 { get; set; }

        public bool Activity7 { get; set; }

        public string LawyerName { get; set; }

        public string AuthorizedSignature { get; set; }

        public string ShareHoldersName { get; set; }

        public double ShareHoldersPhoneNbre { get; set; }

        public float ShareHoldersContribution { get; set; }

        public string ShareHoldersPosition { get; set; }

        



    }
}
