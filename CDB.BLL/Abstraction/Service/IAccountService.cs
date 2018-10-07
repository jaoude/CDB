using CDB.BLL.Dto.Request;
using System.Threading;
using System.Threading.Tasks;

namespace CDB.BLL.Abstraction
{
    public interface IAccountService
    {
        Task CreateRolesAndAdminUser();
    }
}
