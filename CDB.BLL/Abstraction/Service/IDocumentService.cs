using CDB.BLL.Dto.Request;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CDB.BLL.Abstraction
{
    public interface IDocumentService
    {
        Task<List<DocumentDto>> GetDocumentForCompanyAsync(int companyId, CancellationToken ct);
    }
}
