using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pálenice
{
    public partial class ManagePeopleForm : Form
    {
        public bool changed { get; private set; } = false;
        public ManagePeopleForm()
        {
            InitializeComponent();
            foreach(Person person in ManagerOfPersons.Persons)
            {
                Add(person);
            }
            EnableButtons();
        }
        private void Add(Person person)
           => listView1.Items.Add(GetListWievElement(person));

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPersonForm dialog = new AddPersonForm();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                ManagerOfPersons.AddPerson(dialog.Person);
                Add(dialog.Person);
            }
        }

        private ListViewItem GetListWievElement(Person person)
        {
            ListViewItem item = new ListViewItem(person.BirthNum);
            item.SubItems.Add(person.Name);
            item.SubItems.Add(person.Surname);
            item.SubItems.Add(person.City);
            item.SubItems.Add(person.PostalCode.ToString());
            item.SubItems.Add(person.Street);
            item.SubItems.Add(person.DescriptiveNumber);
            item.Tag = person;
            return item;
        }

        private bool ValidateListBox()
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Zvol Položku", "Chyba", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void RemoveSelected()
            => listView1.Items.Remove(listView1.SelectedItems[0]);

        private Person SelectedPerson()
            => (Person)listView1.SelectedItems[0].Tag;

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!ValidateListBox())
                return;
            ManagerOfPersons.Delete(SelectedPerson());
            RemoveSelected();
            changed = true;
            EnableButtons();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (!ValidateListBox())
                return;
            AddPersonForm dialog = AddPersonForm.EditPerson(SelectedPerson());
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                ManagerOfPersons.AddPerson(dialog.Person);
                RemoveSelected();
                listView1.Items.Add(GetListWievElement(dialog.Person));
                changed = true;
            }
            EnableButtons();
        }

        private void ManagePeopleForm_Enter(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
                EditButton_Click(sender, e);
            else
                AddButton_Click(sender, e);
        }

        private void ShowPersonButton_Click(object sender, EventArgs e)
            => new PeopleInformForm((Person)listView1.SelectedItems[0].Tag).ShowDialog();

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
            => EnableButtons();
        
        private void EnableButtons()
        {
            EditButton.Enabled = listView1.SelectedItems.Count != 0;
            ShowPersonButton.Enabled = listView1.SelectedItems.Count != 0;
            DeleteButton.Enabled = listView1.SelectedItems.Count != 0;
        }
    }
}
