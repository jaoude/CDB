using CDB.BLL.Abstraction;
using CDB.BLL.Dto.Request;
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
        // test the code
        // commit 2
        // commit 3
        public async Task<CompanyDto> GetCompanyAsync(int companyId, CancellationToken ct)
        {
            Company companyEntity = await _uow.Companies.GetAsync(companyId, ct);
            CompanyDto companyDto = null;
            Address addressEntity = null;

            if (companyEntity.AddressId != null)
                addressEntity = await _uow.Addresses.GetAsync(companyEntity.AddressId, ct);

            if (companyEntity != null)
            {
                companyDto = _mapper.Map<CompanyDto>(companyEntity);
                if (addressEntity != null)
                    companyDto.Address = _mapper.Map<AddressDto>(addressEntity);
            }

            return companyDto;
        }

        public async Task<int?> UpdateCompanyAsync(CompanyDto companyDto, CancellationToken ct)
        {
            int? result = null;

            if (companyDto != null)
            {
                Company companyEntity = await _uow.Companies.GetAsync(companyDto.Id, ct);
                if (companyEntity != null)
                {
                    if (companyEntity.AddressId.HasValue)
                        companyEntity.Address = await _uow.Addresses.GetAsync(companyEntity.AddressId.Value, ct);

                    _mapper.Map<CompanyDto, Company>(companyDto, companyEntity);

                    if (companyEntity.Address == null)
                        companyEntity.Address = new Address();

                    _mapper.Map<AddressDto, Address>(companyDto.Address, companyEntity.Address);

                    result = await _uow.SaveChangesAsync(ct);
                }
            }

            return result;
        }
    }
}
