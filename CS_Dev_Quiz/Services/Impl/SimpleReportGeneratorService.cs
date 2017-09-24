using CS_Dev_Quiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Dev_Quiz.Services.Impl
{
    public class SimpleReportGeneratorService : IDocumentReportGenerator
    {
        IPrintFormGenerator spfgService = new SimplePrintFormGeneratorService();

        public IEnumerable<DocumentReport> GenerateDocumentReportsFromDocuments(IEnumerable<Document> documents, IEnumerable<DocumentType> docType)
        {
            var documentsWithPackageId = documents.Where(d => docType.Contains(d.DocumentType) && d.PackageId != null);
            var docReportsGroupedById = documentsWithPackageId.GroupBy(d => d.PackageId).Select(g => new DocumentReport()
            {
                PackageId = g.Key,
                Items = g.Select(d => new DocumentReportItem()
                {
                    DocumentId = d.Id,
                    Title = d.Title,
                    DocumentType = d.DocumentType,
                    PrintForm = spfgService.GeneratePrintForm(d)
                })
            });
            return docReportsGroupedById;
        }

        public IEnumerable<DocumentReport> GenerateDocumentReportsFromDocumentsForOrder(IEnumerable<Document> documents)
        {
            return GenerateDocumentReportsFromDocuments(documents, new[] { DocumentType.Order });
        }
    }
}
