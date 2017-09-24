using System.Collections.Generic;

namespace CS_Dev_Quiz.Model
{
    /// <summary>
    /// Определяет модель отчета по документам.
    /// </summary>
    public sealed class DocumentReport
    {
        /// <summary>
        /// Возвращает или задает идентифкатор пакета.
        /// </summary>
        public int? PackageId { get; set; }

        /// <summary>
        /// Возвращает или задает последовательность элементов отчета.
        /// </summary>
        public IEnumerable<DocumentReportItem> Items { get; set; }
    }
}
