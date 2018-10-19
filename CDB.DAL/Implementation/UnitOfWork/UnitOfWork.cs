using CDB.Dal.DbContext;
using CDB.DAL.Abstraction.Repositories;
using CDB.DAL.Abstraction.UnitOfWork;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace CDB.DAL.Implementation.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        private readonly IServiceProvider _serviceProvider;

        public UnitOfWork(ApplicationDbContext db,
            IServiceProvider serviceProvider)
        {
            _db = db;
            _serviceProvider = serviceProvider;
        }

        public ICompanyRepository Companies => _serviceProvider.GetService<ICompanyRepository>();

        public async Task<int> SaveChangesAsync(CancellationToken ct)
        {
            return await _db.SaveChangesAsync(ct);
        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
