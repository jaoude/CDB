using CDB.BLL.Abstraction;
using CDB.DAL.Abstraction.UnitOfWork;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDB.BLL.Implementation
{
    public class BaseService : IBaseService
    {
        protected readonly IUnitOfWork _uow;
        protected readonly ILogger<BaseService> _logger;
        protected readonly IModelMapHelper _mapper;

        public BaseService(IUnitOfWork uow, ILogger<BaseService> logger, IModelMapHelper mapper)
        {
            _uow = uow;
            _logger = logger;
            _mapper = mapper;
        }
    }
}
