using CDB.BLL.Dto.Request;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CDB.BLL.Abstraction
{
    public interface ICompanyService
    {
        Task<int> CreateAsync(CreateCompanyDto companyDto, CancellationToken ct);
        Task<List<CompanyDto>> GetAllAsync (CancellationToken ct);
        Task<int?> UpdateCompanyAsync(CompanyDto companyDto, CancellationToken ct);
        Task<CompanyDto> GetCompanyAsync(int companyId, CancellationToken ct);
    }
}
