using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pálenice
{
    public partial class AddPersonForm : Form
    {
        private string PBirthNum { get => BirthNumTextBox.Text; set => BirthNumTextBox.Text = value; }
        private string PName { get => NameTextBox.Text; set => NameTextBox.Text = value; }
        public string PSurname { get => SurnameTextBox.Text; set => SurnameTextBox.Text = value; }
        public string PStreet { get => StreetTextBox.Text; set => StreetTextBox.Text = value; }
        public string PDescriptiveNumber { get => DescriptiveNumberTextBox.Text;
            set => DescriptiveNumberTextBox.Text = value; }
        private string PCity { get => CitytextBox.Text; set => CitytextBox.Text = value; }
        public int? PPostalCode { 
            get {
                int result;
                if (int.TryParse(PostalCodeTextBox.Text, out result))
                    return result;
                return null;
            } 
    
            set => PostalCodeTextBox.Text = value == null ? "" : value.ToString(); }
        public Person Person { get; private set; }
        public AddPersonForm()
        {
            InitializeComponent();
        }
        public AddPersonForm(string birthNum)
        {
            InitializeComponent();
            BirthNumTextBox.Text = birthNum;
        }

        public static AddPersonForm EditPerson(Person person)
        {
            AddPersonForm form = new AddPersonForm(person.BirthNum);
            form.BirthNumTextBox.Enabled = false;
            if (person == null)
                return form;
            form.PCity = person.City;
            form.PName = person.Name;
            form.PSurname = person.Surname;
            form.PDescriptiveNumber = person.DescriptiveNumber;
            form.PStreet = person.Street;
            form.PPostalCode = person.PostalCode;
            return form;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string message = "";
            message += Person.IsValidBirthNum(BirthNumTextBox.Text) ? "" : "Špatné rodné číslo";
            message += (PPostalCode >= 10000 && PPostalCode <= 99999) || PPostalCode == null ? "" : "\nChybné psč";
            if (message.Length > 0)
            {
                MessageBox.Show(message, "Chyba", MessageBoxButtons.OK);
                DialogResult = DialogResult.None;
                return;
            }
            Person = new Person(PBirthNum, PName, PSurname, PPostalCode, PCity, PStreet, PDescriptiveNumber);
            ManagerOfPersons.AddPerson(Person);
        }


        private void MoveBetweenTextBoxes(object sender, KeyEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            List<List<TextBox>> textBoxes = new List<List<TextBox>> {
                new List<TextBox>{ BirthNumTextBox },
                new List<TextBox>{ CitytextBox, NameTextBox, SurnameTextBox },
                new List<TextBox>{ PostalCodeTextBox, StreetTextBox, DescriptiveNumberTextBox} };
            int row = 0;
            int column = 0;
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (textbox.SelectionStart != textbox.TextLength) { return; }
                    column = 1;
                    break;
                case Keys.Left:
                    if (textbox.SelectionStart != 0) { return; }
                    column = -1;
                    break;
                case Keys.Down:
                    row = 1;
                    break;
                case Keys.Up:
                    row = -1;
                    break;
                default:
                    return;
            }
            for (int i = 0; i < textBoxes.Count; i++)
            {
                for (int j = 0; j < textBoxes[i].Count; j++)
                {
                    if (textBoxes[i][j].Equals(sender))
                    {
                        row += i;
                        column += j;
                    }
                }
            }
            row = (row + textBoxes.Count) % textBoxes.Count;
            column = (column + textBoxes[row].Count) % textBoxes[row].Count;
            textBoxes[row][column].Focus();
        }
    }
}
