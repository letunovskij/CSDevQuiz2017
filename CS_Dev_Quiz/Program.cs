﻿using CS_Dev_Quiz.Services;
using CS_Dev_Quiz.Services.Impl;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CS_Dev_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Q2();
        }

        static void Q1()
        {
            /*
             * Дана последовательность документов (Model.Document) и сервис, который умеет генерировать
             * печатные формы документов (Services.IPrintFormGenerator).
             * 
             * Сформировать последовательность отчетов по документам (Model.DocumentReport) из исходной последовательности так,
             * чтобы в отчетах содержались только заказы (DocumentType.Order), сгруппированные по идентификатору пакета.
             * 
             * Документы, существующие вне пакетов, отбрасывать.
             * 
             * Каждый элемент отчета должен содержать печатную форму: свойство DocumentReportItem.PrintForm должно быть
             * проинициализировано результатом выполнения IPrintFormGenerator.GeneratePrintForm.
             */
        }

        static void Q2()
        {
            /*
             * Логика генерации печатной формы зависит от типа документа.
             * 
             * Реализовать Services.IPrintFormGenerator так, чтобы получить возможность определять логику
             * в зависимости от типа документа.
             *  
             * По возможности, рассмотреть два сценария:
             * 1) перечень типов документов, для которых IPrintFormGenerator может сгенерировать печатную форму, известен статически;
             * 2) перечень типов документов, для которых IPrintFormGenerator может сгенерировать печатную форму, формируется динамически
             *    (плагины).
             *    
             *  Саму логику не реализовывать, достаточно метода-заглушки.
             *  
             *  Продемонстрировать на примере.
             */
            IPrintFormGenerator pfgService = new Q2PrintFormGeneratorService();
            var res = pfgService.GeneratePrintForm(new Model.Document() {
                Id = 1,
                PackageId = null,
                Title = "Hello",
                DocumentType = Model.DocumentType.Contract
            });
            foreach (var value in res)
                Debug.WriteLine(value);
        }

        static void Q3()
        {
            /*
             * Реализовать сервис для периодической отправки документов внешней системе (Serices.IDocumentSender).
             * 
             * Требования:
             * 1) документ можно в любой момент времени поставить в очередь на отправку;
             * 2) документы из очереди отправляются раз в N секунд (N должен как-то задаваться);
             * 3) процесс отправки документов можно прервать;
             * 4) реализация должна быть thread safe.
             * 
             * Постановка в очередь и отправка документа связаны с операциями ввода-вывода
             * (файл, база данных, внешний сервис): предпочтительна асинхронная реализация.
             * 
             *  Продемонстрировать на примере (постановка в очередь, отправка, прерывание процесса отправки).
             */
        }
    }
}
