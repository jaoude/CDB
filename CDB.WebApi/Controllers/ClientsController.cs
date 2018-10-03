using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using CDB.WebApi.Models;
using CDB.WebApi.Models.AccountViewModels;
using CDB.WebApi.Services;
using CDB.BLL.Abstraction;
using System.Threading;
using CDB.BLL.Dto.Request;

namespace CDB.WebApi.Controllers
{
    public class ClientsController : BaseController<ClientsController>
    { 
        private readonly IClientsService _clientService;

        public ClientsController(
            IClientsService clientService,
            IBaseService baseService,
            ILogger<ClientsController> logger): base(logger, baseService)
        {
            _clientService = clientService;
        }

        [AllowAnonymous]
        public async Task<ActionResult> CreateAsync()
        {
            return View();
        }

        [AllowAnonymous]
        public async Task<ActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> CreateAsync([FromBody]CreateClientDto clientDto, CancellationToken ct)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    await _clientService.CreateClientAsync(clientDto, ct);
                }
                catch (Exception e)
                {
                }
                return View();
            }
            else
            {
                return View(clientDto);
            }
        }
    }
}
