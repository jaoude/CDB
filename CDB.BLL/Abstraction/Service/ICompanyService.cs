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
        Task<PaneCompanyDto> GetCompanyPaneAsync(int companyId, CancellationToken ct);
        // Task<PaneShareholderDto> GetShareholderPaneAsync(int companyId, CancellationToken ct);
    }
}
