using CS_Dev_Quiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Dev_Quiz.Services
{
    /// <summary>
    /// Представляет сервис для формирования отчетов по документам
    /// </summary>
    public interface IDocumentReportGenerator
    {
        /// <summary>
        /// Формирует последовательность отчетов по документам (Model.DocumentReport <see cref="Model.DocumentReport">)
        /// </summary>
        /// <remarks>
        /// В выходной последовательности отчетов содержатся документы, сгруппированные по идентификатору пакета 
        /// Документы, существующие вне пакетов, отбрасываются из выходной последовательности
        /// </remarks>
        /// <param name="documents">Исходная последовательность документов</param>
        /// <param name="docType">Типы документов, которые должны присутствовать в отчетах</param>
        /// <returns>Отчеты по документам</returns>
        IEnumerable<DocumentReport> GenerateDocumentReportsFromDocuments(IEnumerable<Document> documents, IEnumerable<DocumentType> docType);

        /// <summary>
        /// Формирует последовательность отчетов по заказам (DocumentType.Order <see cref="Model.DocumentType.Order">)
        /// </summary>
        /// <remarks>
        /// В выходной последовательности отчетов содержатся документы, сгруппированные по идентификатору пакета 
        /// Документы, существующие вне пакетов, отбрасываются из выходной последовательности
        /// </remarks> 
        /// <param name="documents">Исходная последовательность документов</param>
        /// <returns>Отчеты по заказам</returns>
        IEnumerable<DocumentReport> GenerateDocumentReportsFromDocumentsForOrder(IEnumerable<Document> documents);
    }
}
