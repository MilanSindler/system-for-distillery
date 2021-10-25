using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pálenice
{
    public partial class DateSelect : Form
    {
        public int Year
        {
            get => int.Parse(YearTextBox.Text);
            private set => YearTextBox.Text = value.ToString();
        }
        public Month Month
        {
            get => (Month)MonthComboBox.SelectedIndex;
            private set => MonthComboBox.SelectedIndex = (int)value;
        }
        public DateSelect()
        {
            InitializeComponent();
            Year = DateTime.Now.Year;
            Month = (Month)DateTime.Now.Month - 1;
        }
        private void ValidateYearTextBox(object sender, CancelEventArgs e)
        {
            bool value = int.TryParse(YearTextBox.Text, out _);
            e.Cancel = !value;
            if (!value)
                YearTextBox.Focus();
        }
    }
}
