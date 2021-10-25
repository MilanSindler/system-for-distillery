using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pálenice
{
    public partial class BirthNumDialog : Form
    {
        public string result;
        public BirthNumDialog(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!Person.IsValidBirthNum(BirthNumTextBox.Text))
            {
                MessageBox.Show("Chyvbé rodné číslo", "Cbyba", MessageBoxButtons.OK);
                DialogResult = DialogResult.None;
                return;
            }
            result = BirthNumTextBox.Text;
        }

        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            bool value = Person.IsValidBirthNum(BirthNumTextBox.Text);
            e.Cancel = !value;
            if (!value)
                BirthNumTextBox.Focus();
        }
    }
}
