using CDB.Core.Models;
using CDB.Dal.DbContext;
using CDB.DAL.Abstraction.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDB.DAL.Implementation.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(ApplicationDbContext _db)
            : base(_db)
        {
        }
    }
}
