using CDB.Core.Models;
using CDB.Dal.DbContext;
using CDB.DAL.Abstraction.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDB.DAL.Implementation.Repositories
{
    public class ClientsRepository : Repository<Client>, IClientsRepository
    {
        public ClientsRepository(ApplicationDbContext _db)
            : base(_db)
        {
        }
    }
}
