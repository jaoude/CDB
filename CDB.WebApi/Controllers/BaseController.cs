using CDB.BLL.Abstraction;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;

namespace CDB.WebApi.Controllers
{
    /// <summary>
    /// Base controller
    /// </summary>
    [Authorize]
    public class BaseController<T> : Controller
    {
        protected readonly ILogger<T> _logger;
        protected readonly IBaseService _baseEngine;

        /// <summary>
        /// Constrctor
        /// </summary>
        public BaseController(ILogger<T> logger, IBaseService baseEngine)
        {
            _logger = logger;
            _baseEngine = baseEngine;
        }
    }
}