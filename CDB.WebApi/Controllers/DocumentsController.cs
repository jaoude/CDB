using CDB.BLL.Abstraction;
using CDB.BLL.Dto.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CDB.WebApi.Controllers
{
    [Route("[controller]/[action]")]
    public class DocumentsController : BaseController<DocumentsController>
    { 
        private readonly IDocumentService _documentService;

        public DocumentsController(
            IDocumentService documentService,
            IBaseService baseService,
            ILogger<DocumentsController> logger): base(logger, baseService)
        {
            _documentService = documentService;
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> ListDocuments(int companyId, CancellationToken ct)
        {
            List<DocumentDto> result = new List<DocumentDto>();
            if (ModelState.IsValid)
            {
                try
                {
                    result = await _documentService.GetDocumentForCompanyAsync(companyId, ct);
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                    throw (e);
                }
            }
            return PartialView("_ListDocuments", result);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> UpdateDocumentPaneAsync(int id, CancellationToken ct)
        {
            DocumentPaneDto result = new DocumentPaneDto();
            if (ModelState.IsValid)
            {
                try
                {
                    result.CompanyId = id;
                    result.Documents = await _documentService.GetDocumentForCompanyAsync(id, ct);
                    //result = await _documentService.GetDocuemntPaneAsync(id, ct);
                    //ViewBag.CompanyTypes = new SelectList(Enums.CompanyTypes, "Id", "DisplayText");
                    //ViewBag.Districts = new SelectList(Enums.Governates, "Id", "DisplayText");
                    //ViewBag.Kazas = new SelectList(Enums.Kazas, "Id", "DisplayText");
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
