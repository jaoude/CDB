using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CDB.Core.Models;

namespace CDB.DAL.Abstraction.Repositories
{
    public interface IShareholderRepository : IRepository<Shareholder>
    {
        Task <List<Shareholder>> GetAllByCompanyAsync(int companyId, CancellationToken ct);
    }
}

