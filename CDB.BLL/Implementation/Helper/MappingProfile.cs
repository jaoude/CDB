using CDB.BLL.Dto.Request;
using CDB.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDB.BLL.Implementation
{
    public class MappingProfile : AutoMapper.Profile
    {
        // CreateMap <TSource, TDestination> (); <------ Use this signature

        public MappingProfile()
        {
            CreateMap<CreateClientDto, Client>();
        }
    }
}
