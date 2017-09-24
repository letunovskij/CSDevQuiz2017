using CS_Dev_Quiz.Model;

namespace CS_Dev_Quiz.Services
{
    /// <summary>
    /// Представляет генератор печатных форм документов.
    /// </summary>
    public interface IPrintFormGenerator
    {
        /// <summary>
        /// Генерирует печатную форму документа.
        /// </summary>
        /// <param name="document">
        /// Документ, для которого нужно сгенерировать печатную форму.
        /// </param>
        /// <returns>
        /// Печатная форма документа (PDF, сериализованный в массив байт).
        /// </returns>
        byte[] GeneratePrintForm(Document document);
    }
}
