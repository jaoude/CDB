using CDB.BLL.Dto.Request;
using CDB.BLL.Dto.Response;
using CDB.Core.Models;

namespace CDB.BLL.Implementation
{
    public class MappingProfile : AutoMapper.Profile
    {
        // CreateMap <TSource, TDestination> (); <------ Use this signature

        public MappingProfile()
        {
            CreateMap<CreateCompanyDto, Company>();
            CreateMap<Company, CompanyDto>();

            CreateMap<UpdateCompanyDto, Company>();
            CreateMap<Company, UpdateCompanyDto>();

            CreateMap<UpdateAddressDto, Address>();
            CreateMap<Address, UpdateAddressDto>();

            CreateMap<DocumentDto, Document>();
            CreateMap<Document, DocumentDto>();
        }
    }
}
