using CDB.BLL.Abstraction;
using CDB.BLL.Dto.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            ILogger<DocumentsController> logger) : base(logger, baseService)
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

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> UploadDocument(IFormFile file)
        {
            long size = file.Length;

            // full path to file in temp location
            var filePath = Path.GetTempFileName();
            //byte[] fileBytes = new byte[];
            if (file.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    await _documentService.UploadFile(fileBytes, new CancellationToken());
                    return  RedirectToAction("UpdateDocumentPaneAsync", new { id = 1, ct = new CancellationToken() });
                }
                /* using (var stream = new FileStream(filePath, FileMode.Create))
                 {
                     await file.CopyToAsync(stream);
                 }
             }*/

                
            }
            return Ok();
        }
    }
}
