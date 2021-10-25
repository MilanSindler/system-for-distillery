using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Pálenice
{
    static class ManagerOfRecords
    {
        private static List<Record> Records = new List<Record>();
        private static string FileName { get; } = "Records.csv";
        static ManagerOfRecords()
        {
            if (!File.Exists(FileName))
            {
                File.Create(FileName);
                return;
            }
            using StreamReader reader = new StreamReader(FileName);
            string line;
            while((line = reader.ReadLine()) != null)
            {
                try
                {
                    Records.Add(new Record(line));
                }
                catch { }
            }
        }
        public static List<Record> GetRecords(int year, Month month)
            =>(from record in Records where record.Month == month && record.Year == year select record).ToList();

        public static List<Record> GetRecords(Person person)
            => (from record in Records where record.Person == person select record).ToList();
        public static void AddRecord(Record record)
            => Records.Add(record);
        public static void Save()
        {
            using StreamWriter writer = new StreamWriter(FileName);
            foreach (Record record in Records)
            {
                writer.WriteLine(record.ToCsv());
            }
        }

        internal static void Delete(Record record)
            => Records.Remove(record);
    }
}
