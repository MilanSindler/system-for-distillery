using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pálenice
{
    public partial class PeopleInformForm : Form
    {
        public PeopleInformForm(Person person)
        {
            InitializeComponent();
            BirthNumLabel.Text = person.BirthNum;
            NameLabel.Text = person.Name;
            SurnameLabel.Text = person.Surname;
            CityLabel.Text = person.City;
            PostalCodeLabel.Text = person.PostalCode.ToString();
            StreetLabel.Text = person.Street;
            DescriptiveNumberLabel.Text = person.DescriptiveNumber;
            listView1.Items.Clear();
            double count = 0;
            ManagerOfRecords.GetRecords(person).ForEach(x => { count += x.Etanol; listView1.Items.Add(GetListWievElement(x)); });
            LaaLabel.Text = count.ToString();
        }


        private ListViewItem GetListWievElement(Record record)
        {
            ListViewItem item = new ListViewItem(record.Year.ToString());
            item.SubItems.Add(record.Month.ToString());
            item.SubItems.Add(record.Etanol.ToString());
            item.Tag = record;
            return item;
        }
    }
}
