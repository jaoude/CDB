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
    public class DocumentService : BaseService, IDocumentService
    {

       
       public async Task UploadFile(byte[] fileBytes, CancellationToken ct)
        {
            Document document = new Document();
            document.CategoryId = 1;
            document.SubCategoryId = 1;
            document.FileByte = fileBytes;
            document.CompanyId = 1;
            document.Name = "abc";
            document.UploadedOn = DateTime.UtcNow;
            _uow.Documents.Add(document);
            _uow.SaveChanges();

        }
        public DocumentService(IUnitOfWork uow, ILogger<DocumentService> logger, IModelMapHelper mapper) : base(uow, logger, mapper)
        {
        }

        public async Task<List<DocumentDto>> GetDocumentForCompanyAsync(int companyId, CancellationToken ct)
        {
            await Task.FromResult(0);

            List<DocumentDto> documentDtos = new List<DocumentDto>();

            documentDtos.AddRange(new List<DocumentDto>()
            {
                new DocumentDto(){ Id = 1, CategoryId = 1, SubCategoryId = 1, CompnayId = 1, Name = "One.pdf", UploadedOn = DateTime.Now },
                new DocumentDto(){ Id = 2, CategoryId = 2, SubCategoryId = 2, CompnayId = 1, Name = "Two.pdf", UploadedOn = DateTime.Now },
                new DocumentDto(){ Id = 3, CategoryId = 3, SubCategoryId = 3, CompnayId = 1, Name = "Three.pdf", UploadedOn = DateTime.Now },
                new DocumentDto(){ Id = 4, CategoryId = 4, SubCategoryId = 4, CompnayId = 1, Name = "Four.pdf", UploadedOn = DateTime.Now },
                new DocumentDto(){ Id = 5, CategoryId = 5, SubCategoryId = 5, CompnayId = 1, Name = "Five.pdf", UploadedOn = DateTime.Now },
                new DocumentDto(){ Id = 6, CategoryId = 6, SubCategoryId = 6, CompnayId = 1, Name = "Six.pdf", UploadedOn = DateTime.Now },
                new DocumentDto(){ Id = 7, CategoryId = 7, SubCategoryId = 7, CompnayId = 1, Name = "Seven.pdf", UploadedOn = DateTime.Now },
                new DocumentDto(){ Id = 8, CategoryId = 8, SubCategoryId = 8, CompnayId = 1, Name = "Eight.pdf", UploadedOn = DateTime.Now },
                new DocumentDto(){ Id = 9, CategoryId = 9, SubCategoryId = 9, CompnayId = 1, Name = "Nine.pdf", UploadedOn = DateTime.Now },
                new DocumentDto(){ Id = 10, CategoryId = 10, SubCategoryId = 10, CompnayId = 1, Name = "Ten.pdf", UploadedOn = DateTime.Now },
                new DocumentDto(){ Id = 11, CategoryId = 11, SubCategoryId = 11, CompnayId = 1, Name = "Eleven.pdf", UploadedOn = DateTime.Now },
                new DocumentDto(){ Id = 12, CategoryId = 12, SubCategoryId = 12, CompnayId = 1, Name = "Twelve.pdf", UploadedOn = DateTime.Now },
                new DocumentDto(){ Id = 13, CategoryId = 13, SubCategoryId = 13, CompnayId = 1, Name = "Thirteen.pdf", UploadedOn = DateTime.Now }
            });

            return documentDtos;
            
        }

    }
}
