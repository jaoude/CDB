using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CDB.Core.Models;
using CDB.Dal.DbContext;
using CDB.DAL.Abstraction.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CDB.DAL.Implementation.Repositories
{
    public class ShareholderRepository : Repository<Shareholder>, IShareholderRepository
    {
        public ShareholderRepository(ApplicationDbContext _db)
            : base(_db)
        {
        }

        public async Task<List<Shareholder>> GetAllByCompanyAsync(int companyId, CancellationToken ct)
        {
            return await _db.Set<Shareholder>()
                .Where(c => c.CompanyId == companyId)
                .ToListAsync(ct);
        }
    }
}
