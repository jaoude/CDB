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

            CreateMap<AddressDto, Address>();
            CreateMap<Address, AddressDto>();

            CreateMap<DocumentDto, Document>();
            CreateMap<Document, DocumentDto>();

            CreateMap<Shareholder, ShareholderDto>();

            CreateMap<ShareholderDto, Shareholder>()
                .ForMember( x=> x.AddressId, opt => opt.Ignore())
                .ForMember(x => x.CompanyId, opt => opt.Ignore());
        }
    }
}
