using CDB.DAL.Abstraction.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CDB.DAL.Abstraction.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRepository Companies { get; }

        Task<int> SaveChangesAsync(CancellationToken ct);

        int SaveChanges();
    }
}
