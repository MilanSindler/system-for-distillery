using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pálenice
{
    public partial class EditRecord : Form
    {
        public double Etanol { 
            get => double.Parse(EtanolTextBox.Text.Replace(",", ".")); 
            private set => EtanolTextBox.Text = value.ToString(); }
        public string BirthNum {
            get => BirthNumTextBox.Text;
            private set => BirthNumTextBox.Text = value; }
        public EditRecord(string birthnum, double etanol)
        {
            InitializeComponent();
            Etanol = etanol;
            BirthNum = birthnum;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string message = "";
            message += Person.IsValidBirthNum(BirthNumTextBox.Text) ? "" : "Špatné rodné číslo";
            message += double.TryParse(EtanolTextBox.Text.Replace(",", "."), out _) ? "" : "\nChybný údaj v etanolu";
            if (message.Length > 0)
            {
                MessageBox.Show(message, "Chyba", MessageBoxButtons.OK);
                return;
            }
        }

        private void EditPersonButton_Click(object sender, EventArgs e)
        {
            AddPersonForm dialog = AddPersonForm.EditPerson(ManagerOfPersons.GetPerson(BirthNumTextBox.Text));
            dialog.ShowDialog();
        }
    }
}
