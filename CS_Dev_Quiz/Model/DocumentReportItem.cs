namespace CS_Dev_Quiz.Model
{
    /// <summary>
    /// Представляет модель элемента отчета по документам.
    /// </summary>
    public sealed class DocumentReportItem
    {
        /// <summary>
        /// Возвращает или задает идентификатор документа.
        /// </summary>
        public int DocumentId { get; set; }

        /// <summary>
        /// Возвращает или задает название документа.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает или задает тип документа.
        /// </summary>
        public DocumentType DocumentType { get; set; }

        /// <summary>
        /// Возвращает или задает содержимое печатной формы документа.
        /// </summary>
        public byte[] PrintForm { get; set; }
    }
}
