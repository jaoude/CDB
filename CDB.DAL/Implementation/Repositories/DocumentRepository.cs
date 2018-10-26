using System;
using System.Collections.Generic;
using System.Text;
using CDB.Core.Models;
using CDB.Dal.DbContext;
using CDB.DAL.Abstraction.Repositories;

namespace CDB.DAL.Implementation.Repositories
{
   public class DocumentRepository : Repository<Document>, IDocumentRepository
    {
        public DocumentRepository(ApplicationDbContext _db)
            : base(_db)
        {
        }
    }
}
