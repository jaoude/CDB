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

namespace CDB.BLL.Implementation
{
    public class ClientsService : BaseService, IClientsService
    {

        public ClientsService(IUnitOfWork uow, ILogger<ClientsService> logger, IModelMapHelper mapper) : base(uow, logger, mapper)
        {
        }

        public async Task CreateClientAsync(CreateClientDto clientDto, CancellationToken ct)
        {
            if (clientDto == null)
                throw new NullReferenceException();

            Client clientEntity = _mapper.Map<Client>(clientDto);

            if (clientEntity == null)
                throw new NullReferenceException();

            _uow.Clients.Add(clientEntity);

            await _uow.SaveChangesAsync(ct);
            
        }
    }
}
