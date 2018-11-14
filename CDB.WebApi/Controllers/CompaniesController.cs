using CDB.BLL.Abstraction;
using CDB.BLL.Dto.Request;
using CDB.BLL.Dto.Response;
using CDB.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CDB.WebApi.Controllers
{
    [Route("[controller]/[action]")]
    public class CompaniesController : BaseController<CompaniesController>
    { 
        private readonly ICompanyService _companyService;

        public CompaniesController(
            ICompanyService companyService,
            IBaseService baseService,
            ILogger<CompaniesController> logger): base(logger, baseService)
        {
            _companyService = companyService;
        }


        [AllowAnonymous]
        [HttpGet]
        public ActionResult CreateAsync(bool? saved)
        {
            if (saved.HasValue && saved.Value)
                ViewBag.Message = "Saved Successfully";

            CreateCompanyDto createCompanyDto = new CreateCompanyDto();
            ViewBag.CompanyTypes = new SelectList(Enums.CompanyTypes, "Id", "DisplayText");
            //createCompanyDto.Banks = new SelectList(Enums.Banks, "Id", "DisplayText");

            return View(createCompanyDto);
        }
        
        

        

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> CreateAsync(CreateCompanyDto companyDto, CancellationToken ct)
        {
            int companyId = 0;
            if (ModelState.IsValid)
            {
                try
                {
                    companyId = await _companyService.CreateAsync(companyDto, ct);
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                }
                return RedirectToAction("UpdateCompanyPaneAsync",  new { id = companyId, saved = true });
            }
            else
            {
                return View(companyDto);
            }
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> Index(CancellationToken ct)
        {
            List<CompanyDto> result = new List<CompanyDto>();
            if (ModelState.IsValid)
            {
                try
                {
                    result = await _companyService.GetAllAsync(ct);
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    throw (e);
                }
            }
            return View(result);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> UpdateCompanyPaneAsync(int id, CancellationToken ct,bool? saved)
        {
             if (saved.HasValue && saved.Value)
                 ViewBag.Message = "Saved Successfully";

            CompanyPaneDto result = new CompanyPaneDto();
            if (ModelState.IsValid)
            {
                try
                {
                    result = await _companyService.GetCompanyPaneAsync(id, ct);
                    ViewBag.CompanyTypes = new SelectList(Enums.CompanyTypes, "Id", "DisplayText");
                    ViewBag.Districts = new SelectList(Enums.Governates, "Id", "DisplayText");
                    ViewBag.Kazas = new SelectList(Enums.Kazas, "Id", "DisplayText");
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    throw (e);
                }
            }
            return View(result);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> UpdateShareholderPaneAsync(int id, CancellationToken ct)
        {
            ShareholderPaneDto result = new ShareholderPaneDto();
            if (ModelState.IsValid)
            {
                try
                {
                    result = await _companyService.GetShareholderPaneAsync(id, ct);
                    ViewBag.CompanyTypes = new SelectList(Enums.CompanyTypes, "Id", "DisplayText");
                    ViewBag.Districts = new SelectList(Enums.Governates, "Id", "DisplayText");
                    ViewBag.Kazas = new SelectList(Enums.Kazas, "Id", "DisplayText");
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    throw (e);
                }
            }
            return View(result);
        }
    }
}
