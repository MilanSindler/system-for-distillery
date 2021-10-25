using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace Pálenice
{
    public static class ExcelWorker
    {
        private static int StartRow { get; } = 11;
        private static int StartColumn { get; } = 4;

        public static void Export(List<Record> records, string path, string pathToTemplate)
        {
            Application XlApp = new Application();
            if (XlApp == null || !pathToTemplate.EndsWith(".xls"))
                throw new Exception("Not installed");
            Workbook xlWorkBook = XlApp.Workbooks.Open(pathToTemplate);
            Worksheet xlWorkSheet = xlWorkBook.Worksheets[1];
            for (int i = 0; i < records.Count; i++)
            {
                WriteRecord(records[i], xlWorkSheet, i + 11);
            }
            xlWorkBook.SaveAs(path);
            xlWorkBook.Close();
            XlApp.Quit();
        }
        public static List<Record> Load(string file, int year, Month month)
        {
            Application XlApp = new Application();
            if (XlApp == null || !file.EndsWith(".xls") || !file.EndsWith(".xlsx"))
                throw new Exception("Not installed");
            List<Record> records = new List<Record>();
            Workbook xlWorkBook = XlApp.Workbooks.Open(file);
            Worksheet xlWorkSheet = xlWorkBook.Worksheets[1];
            int i = StartRow;
            while (((Range)xlWorkSheet.Cells[i, 4]).Value2 != "")
            {
                records.Add(ReadRecord(xlWorkSheet, i, year, month));
                i++;
            }
            xlWorkBook.Close(0);
            XlApp.Quit();
            return records;
        }

        private static void WriteRecord(Record record, Worksheet xlWorkSheet, int i) {
            ((Range)xlWorkSheet.Cells[i, StartColumn]).Value2 = record.Person.BirthNum;
            ((Range)xlWorkSheet.Cells[i, StartColumn + 1]).Value2 = record.Person.Surname;
            ((Range)xlWorkSheet.Cells[i, StartColumn + 2]).Value2 = record.Person.Name;
            ((Range)xlWorkSheet.Cells[i, StartColumn + 3]).Value2 = record.Person.City;
            ((Range)xlWorkSheet.Cells[i, StartColumn + 4]).Value2 = record.Person.Street;
            ((Range)xlWorkSheet.Cells[i, StartColumn + 5]).Value2 = record.Person.DescriptiveNumber;
            ((Range)xlWorkSheet.Cells[i, StartColumn + 6]).Value2 = record.Person.PostalCode;
            ((Range)xlWorkSheet.Cells[i, StartColumn + 7]).Value2 = record.Etanol;
        }
        private static Record ReadRecord(Worksheet sheet, int i, int year, Month month)
        {
            ManagerOfPersons.AddPerson(new Person(((Range)sheet.Cells[i, 4]).Value2,
                                 ((Range)sheet.Cells[i, 6]).Value2,
                                 ((Range)sheet.Cells[i, 5]).Value2,
                                 (int?)((Range)sheet.Cells[i, 10]).Value2,
                                 ((Range)sheet.Cells[i, 7]).Value2,
                                 ((Range)sheet.Cells[i, 8]).Value2,
                                 ((Range)sheet.Cells[i, 9]).Value2));
            return new Record(year, month, ((Range)sheet.Cells[i, 4]).Value2, ((Range)sheet.Cells[i, 11]).Value2); 
        }
    } 
}
