using CDB.BLL.Dto.Request;
using CDB.BLL.Dto.Response;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CDB.BLL.Abstraction
{
    public interface IShareholderService
    {
        Task<List<ShareholderDto>> GetAllByCompanyAsync (int companyId, CancellationToken ct);
        Task<ShareholderDto> GetShareholderByIdAsync (int shareholderId, CancellationToken ct);
        Task<int?> UpdateShareholderAsync(ShareholderDto shareholder, CancellationToken ct);
    }
}
