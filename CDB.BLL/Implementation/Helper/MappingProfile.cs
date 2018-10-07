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
            CreateMap<CreateClientDto, Client>();
            CreateMap<Client, ClientDto>();
        }
    }
}
