﻿using CDB.BLL.Abstraction;
using CDB.BLL.Dto.Request;
using CDB.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace CDB.WebApi.Controllers
{
    [Route("[controller]/[action]")]
    public class ShareholdersController : BaseController<ShareholdersController>
    { 
        private readonly IShareholderService _shareholderService;

        public ShareholdersController(
            IShareholderService shareholderService,
            IBaseService baseService,
            ILogger<ShareholdersController> logger): base(logger, baseService)
        {
            _shareholderService = shareholderService;
        }

        
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> Index(int id, CancellationToken ct)
        {
            PaneShareholderDto model = new PaneShareholderDto();

            model.CompanyId = id;
            model.Shareholders = await _shareholderService.GetAllByCompanyAsync(id, ct);
            
            return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Create(int companyId, CancellationToken ct)
        {
            ShareholderDto model = new ShareholderDto() { CompanyId = companyId };
            ViewBag.CompanyTypes = new SelectList(Enums.CompanyTypes, "Id", "DisplayText");
            ViewBag.Districts = new SelectList(Enums.Governates, "Id", "DisplayText");
            ViewBag.Kazas = new SelectList(Enums.Kazas, "Id", "DisplayText");

            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Create(ShareholderDto model, CancellationToken ct)
        {
            int? result = null;
            if (ModelState.IsValid)
            {
                result = await _shareholderService.UpdateShareholderAsync(model, ct);
            }

            if (result.HasValue && result.Value > 0)
                return RedirectToAction("Edit", new { id = model.Id, saved = true });
            else
                return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> Edit(int id, CancellationToken ct, bool? saved)
        {
            ShareholderDto shareHolder = await _shareholderService.GetShareholderByIdAsync(id, ct);

            if (shareHolder == null)
                return View("Error");

            return View(shareHolder);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Edit(ShareholderDto model, CancellationToken ct)
        {
            int? result = null;
            if (ModelState.IsValid)
            {
               result = await _shareholderService.UpdateShareholderAsync(model, ct);
            }

            if (result.HasValue && result.Value > 0)
                return RedirectToAction("Edit", new { id = model.Id, saved = true });
            else
                return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> View(int id, CancellationToken ct)
        {
            ShareholderDto shareHolder = await _shareholderService.GetShareholderByIdAsync(id, ct);

            if (shareHolder == null)
                return View("Error");

            return View(shareHolder);
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
