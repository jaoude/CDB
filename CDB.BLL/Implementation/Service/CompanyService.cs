using CDB.BLL.Abstraction;
using CDB.BLL.Dto.Request;
using CDB.BLL.Dto.Response;
using CDB.Common;
using CDB.Core.Models;
using CDB.DAL.Abstraction.UnitOfWork;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CDB.BLL.Implementation
{
    public class CompanyService : BaseService, ICompanyService
    {

        public CompanyService(IUnitOfWork uow, ILogger<CompanyService> logger, IModelMapHelper mapper) : base(uow, logger, mapper)
        {
        }

        public async Task<int> CreateAsync(CreateCompanyDto createCompanyDto, CancellationToken ct)
        {
            if (createCompanyDto == null)
                throw new NullReferenceException();

            Company companyEntity = _mapper.Map<Company>(createCompanyDto);

            if (companyEntity == null)
                throw new NullReferenceException();

            _uow.Companies.Add(companyEntity);

            await _uow.SaveChangesAsync(ct);

            return companyEntity.Id;
        }

        public async Task<List<CompanyDto>> GetAllAsync(CancellationToken ct)
        {
            List<Company> companyEntities =  await _uow.Companies.GetAllAsync(ct);    
            List<CompanyDto> companyDtos = _mapper.Map<List<CompanyDto>>(companyEntities);

            return companyDtos;
        }

        public async Task<CompanyPaneDto> GetCompanyPaneAsync(int companyId, CancellationToken ct)
        {
            Company companyEntity = await _uow.Companies.GetAsync(companyId, ct);
            CompanyPaneDto companyPaneDto = new CompanyPaneDto() { CompanyId = companyId };
            
            companyPaneDto.Company = _mapper.Map<CreateCompanyDto>(companyEntity);
            if (companyEntity.Address != null)
                companyPaneDto.Address = _mapper.Map<UpdateAddressDto>(companyEntity.Address);
            else
                companyPaneDto.Address = new UpdateAddressDto() { Kaza = Enums.Kazas[0].Id, District = Enums.Governates[0].Id };

            return companyPaneDto;
        }

        public async Task<ShareholderPaneDto> GetShareholderPaneAsync(int companyId, CancellationToken ct)
        {
            // List<Shareholder> shareholderEntities = await _uow.Shareholders.GetAllAsync(companyId, ct);

            return null;
        }
    }
}
