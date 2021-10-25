using System;
using System.Collections.Generic;
using System.Text;

namespace Pálenice
{
    public class Record
    {
        public int Year { get; set; }
        public Month Month { get; set; }
        private string BirthNum {get; set; }
        public Person Person { get
            {
                Person person = ManagerOfPersons.GetPerson(BirthNum);
                return person ?? new Person("", "", "", null, "", "", "");
            } }
        public double Etanol { get; set; }
        public Record(string line)
        {
            string[] parts = line.Split(";");
            Year = int.Parse(parts[0]);
            Month = (Month)int.Parse(parts[1]);
            if (!Person.IsValidBirthNum(parts[2]))
                throw new FormatException();
            BirthNum = parts[2];
            Etanol = double.Parse(parts[3]);
        }

        public Record(int year, Month month, string birthNum, double etanol)
        {
            Year = year;
            Month = month;
            BirthNum = birthNum;
            Etanol = etanol;
        }

        public string ToCsv()
        {
            return string.Format("{0};{1};{2};{3}", Year, (int)Month, BirthNum, Etanol);
        }
    }
}
