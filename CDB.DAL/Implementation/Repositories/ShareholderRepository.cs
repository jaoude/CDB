using System;
using System.Collections.Generic;
using System.Text;
using CDB.Core.Models;
using CDB.Dal.DbContext;
using CDB.DAL.Abstraction.Repositories;

namespace CDB.DAL.Implementation.Repositories
{
   public class ShareholderRepository : Repository<Shareholder>, IShareholderRepository
    {
        public ShareholderRepository(ApplicationDbContext _db)
            : base(_db)
        {
        }
    }
}
