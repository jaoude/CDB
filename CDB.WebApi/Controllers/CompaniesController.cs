using CDB.BLL.Abstraction;
using CDB.BLL.Dto.Request;
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
        public async Task<ActionResult> View (int id, CancellationToken ct)
        {
            CompanyDto companyDto = await _companyService.GetCompanyAsync(id, ct);

            if (companyDto == null)
                return View("Error");

            return View(companyDto);
        }



        [AllowAnonymous]
        [HttpGet]
        public ActionResult Create(bool? saved)
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
        public async Task<ActionResult> Create(CreateCompanyDto companyDto, CancellationToken ct)
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
                return RedirectToAction("Edit",  new { id = companyId, created = true });
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
        public async Task<ActionResult> Edit(int id, CancellationToken ct, bool? saved = null, bool? created = null)
        {
            if (saved.HasValue && saved.Value)
                 ViewBag.Message = "Saved Successfully";
            else if (created.HasValue && created.Value)
                ViewBag.Message = "Created Successfully";

            CompanyDto result = new CompanyDto();
            if (ModelState.IsValid)
            {
                try
                {
                    result = await _companyService.GetCompanyAsync(id, ct);
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
        [HttpPost]
        public async Task<ActionResult> Edit(CompanyDto company, CancellationToken ct)
        {
            int? result = null;

            if (ModelState.IsValid)
            {
                result = await _companyService.UpdateCompanyAsync(company, ct);
            }

            if (result.HasValue && result.Value >= 0)
                return RedirectToAction("Edit", new { id = company.Id, saved = true });
            else
                return View();
        }
        
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
               
            }
            CreateCompanyDto company = new CreateCompanyDto();
            if (company == null)
            {
                
            }
            return View(company);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CreateCompanyDto company = new CreateCompanyDto();
            ViewBag.Remove(id);
            ViewBag.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
