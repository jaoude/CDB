using CDB.BLL.Abstraction;
using CDB.BLL.Dto.Request;
using CDB.BLL.Dto.Response;
using CDB.Common;
using CDB.Core.Models;
using CDB.DAL.Abstraction.UnitOfWork;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CDB.BLL.Implementation
{
    public class ShareholderService : BaseService, IShareholderService
    {

        public ShareholderService(IUnitOfWork uow, ILogger<ShareholderService> logger, IModelMapHelper mapper) : base(uow, logger, mapper)
        {
        }

        public async Task<List<ShareholderDto>> GetAllByCompanyAsync (int companyId, CancellationToken ct)
        {
            List <Shareholder> shareHolderEntities = await _uow.Shareholders.GetAllByCompanyAsync(companyId, ct);
            List <ShareholderDto> shareHolders = _mapper.Map<List<ShareholderDto>>(shareHolderEntities);
            return shareHolders;
        }

        public async Task<ShareholderDto> GetShareholderByIdAsync(int shareholderId, CancellationToken ct)
        {
            ShareholderDto shareholder = null;
            Address addressEntity = null;

            Shareholder shareholderEntity = await _uow.Shareholders.GetAsync(shareholderId, ct);
            if(shareholderEntity.AddressId != null)
                addressEntity = await _uow.Addresses.GetAsync(shareholderEntity.AddressId, ct);
            if (shareholderEntity != null)
            {
                shareholder = _mapper.Map<ShareholderDto>(shareholderEntity);
                if(addressEntity != null)
                    shareholder.Address = _mapper.Map<AddressDto>(addressEntity);
                return shareholder;
            }

            return null;
        }

        public async Task<int?> UpdateShareholderAsync(ShareholderDto shareholder, CancellationToken ct)
        {
            int? result = null;
            Shareholder shareholderEntity = null;

            if (shareholder != null)
            {
                shareholderEntity = await _uow.Shareholders.GetAsync(shareholder.Id, ct);
                if (shareholderEntity != null)
                {
                    if (shareholderEntity.AddressId.HasValue)
                        shareholderEntity.Address = await _uow.Addresses.GetAsync(shareholderEntity.AddressId.Value, ct);

                    _mapper.Map<ShareholderDto, Shareholder>(shareholder, shareholderEntity);

                    if (shareholderEntity.Address == null)
                        shareholderEntity.Address = new Address();

                    _mapper.Map<AddressDto, Address>(shareholder.Address, shareholderEntity.Address);

                    result = await _uow.SaveChangesAsync(ct);
                }
            }
            return result;
        }
    }
}
