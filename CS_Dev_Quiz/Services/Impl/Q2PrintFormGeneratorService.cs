using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Dev_Quiz.Model;

namespace CS_Dev_Quiz.Services.Impl
{
    class Q2PrintFormGeneratorService : IPrintFormGenerator
    {
        Dictionary<DocumentType, Func<Document, byte[]>> handleDocumentTypes = new Dictionary<DocumentType, Func<Document, byte[]>>
        {
            { DocumentType.Contract, GenerateContractPrintForm },
            { DocumentType.Order, GenerateOrderPrintForm },
            { DocumentType.Invoice, GenerateOrderPrintForm },
        };

        private static byte[] GenerateInvoicePrintForm(Document document)
        {
            return new byte[] { 0x13 };
        }

        private static byte[] GenerateOrderPrintForm(Document document)
        {
            return new byte[] { 0x14 };
        }

        private static byte[] GenerateContractPrintForm(Document document)
        {
            return new byte[] { 0x15 };
        }

        public byte[] GeneratePrintForm(Document document)
        {
            return handleDocumentTypes[document.DocumentType](document);
        }
    }
}
