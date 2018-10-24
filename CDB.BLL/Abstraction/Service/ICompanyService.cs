using CDB.BLL.Dto.Request;
using CDB.BLL.Dto.Response;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CDB.BLL.Abstraction
{
    public interface ICompanyService
    {
        Task<int> CreateAsync(CreateCompanyDto companyDto, CancellationToken ct);
        Task<List<CompanyDto>> GetAllAsync (CancellationToken ct);
        Task<CompanyPaneDto> GetCompanyPaneAsync(int companyId, CancellationToken ct);
        Task<ShareholderPaneDto> GetShareholderPaneAsync(int companyId, CancellationToken ct);
    }
}
