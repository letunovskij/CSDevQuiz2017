using CS_Dev_Quiz.Model;
using CS_Dev_Quiz.Services.Impl;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestDevQuizProject
{
    [TestClass]
    public class SimpleReportGeneratorServiceTest
    {
        private SimpleReportGeneratorService srgService = new SimpleReportGeneratorService();

        [TestMethod]
        public void GenerateDocumentReportsFromDocumentsForOrderTest()
        {
            var documents = new List<Document>() {
                new Document() { Id = 1, PackageId = 1, Title = "One PidOne", DocumentType = DocumentType.Order },
                new Document() { Id = 2, PackageId = 1, Title = "Two PidOne", DocumentType = DocumentType.Order },
                new Document() { Id = 3, PackageId = 1, Title = "Three PidOne", DocumentType = DocumentType.Invoice },
                new Document() { Id = 4, PackageId = 2, Title = "Four PidTwo", DocumentType = DocumentType.Order },
                new Document() { Id = 5, PackageId = 3, Title = "Five PidThree", DocumentType = DocumentType.Order },
                new Document() { Id = 6, PackageId = 2, Title = "Six PidTwo", DocumentType = DocumentType.Order },
                new Document() { Id = 7, PackageId = 1, Title = "Seven PidOne", DocumentType = DocumentType.Order },
            };

            var docReports = srgService.GenerateDocumentReportsFromDocumentsForOrder(documents);

            Assert.IsNotNull(docReports, "Сервис не сгенерировал отчеты");
            Assert.AreEqual(docReports.Count(), 3, "Сервис не правильно определил количество отчетов");

            // Проверяем правильно ли сервис сгруппировал в отчетах заказы по пакетам (сверяем количество заказов в отчете). 
            // В словаре ключом является номер пакета, значением количество заказов в отчете 
            Dictionary<int, int> expectedDocReportsItemsCount = new Dictionary<int, int>()
            {
                { 1, 3 },
                { 2, 2 },
                { 3, 1 }
            };

            foreach (var docReport in docReports)
            {
                if (docReport.PackageId == null)
                {
                    Assert.Fail("В отчет попал документ без номера пакета");
                }
                else
                {
                    Assert.AreEqual(docReport.Items.Count(), expectedDocReportsItemsCount[(int)docReport.PackageId], "Сервис не правильно сгенерировал отчеты");
                }
            }
        }
    }
}
