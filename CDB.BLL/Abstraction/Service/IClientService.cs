using CDB.BLL.Dto.Request;
using CDB.BLL.Dto.Response;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CDB.BLL.Abstraction
{
    public interface IClientService
    {
        Task CreateAsync(CreateClientDto clientDto, CancellationToken ct);
        Task<List<ClientDto>> GetAllAsync (CancellationToken ct);
    }
}
