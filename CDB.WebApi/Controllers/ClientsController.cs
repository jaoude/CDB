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
using CDB.BLL.Dto.Response;
using CDB.Common;

namespace CDB.WebApi.Controllers
{
    [Route("[controller]/[action]")]
    public class ClientsController : BaseController<ClientsController>
    { 
        private readonly IClientService _clientService;

        public ClientsController(
            IClientService clientService,
            IBaseService baseService,
            ILogger<ClientsController> logger): base(logger, baseService)
        {
            _clientService = clientService;
        }


        [AllowAnonymous]
        [HttpGet]
        public ActionResult CreateAsync(bool? saved)
        {
            if (saved.HasValue && saved.Value)
                ViewBag.Message = "Saved Successfully";

            CreateClientDto createClienDto = new CreateClientDto();
            createClienDto.CompanyTypes = new SelectList(Enums.CompanyTypes, "Id", "DisplayText");
            
            return View(createClienDto);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> CreateAsync(CreateClientDto clientDto, CancellationToken ct)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _clientService.CreateAsync(clientDto, ct);
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                }
                return RedirectToAction("CreateAsync", new { saved = true });
            }
            else
            {
                return View(clientDto);
            }
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> Index(CancellationToken ct)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    List<ClientDto> result = await _clientService.GetAllAsync(ct);
                    return View(result);
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                }
            }
            return View();
        }

    }
}
