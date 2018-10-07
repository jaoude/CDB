using CDB.BLL.Abstraction;
using CDB.BLL.Dto.Request;
using CDB.Core.Models;
using CDB.DAL.Abstraction.UnitOfWork;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CDB.BLL.Implementation;
using CDB.BLL.Dto.Response;

namespace CDB.BLL.Implementation
{
    public class ClientService : BaseService, IClientService
    {

        public ClientService(IUnitOfWork uow, ILogger<ClientService> logger, IModelMapHelper mapper) : base(uow, logger, mapper)
        {
        }

        public async Task CreateAsync(CreateClientDto createClientDto, CancellationToken ct)
        {
            if (createClientDto == null)
                throw new NullReferenceException();

            Client clientEntity = _mapper.Map<Client>(createClientDto);

            if (clientEntity == null)
                throw new NullReferenceException();

            _uow.Clients.Add(clientEntity);

            await _uow.SaveChangesAsync(ct);
        }

        public async Task<List<ClientDto>> GetAllAsync(CancellationToken ct)
        {
            List<Client> clientEntities =  await _uow.Clients.GetAllAsync(ct);    
            List<ClientDto> clientDtos = _mapper.Map<List<ClientDto>>(clientEntities);

            return clientDtos;
        }
    }
}
