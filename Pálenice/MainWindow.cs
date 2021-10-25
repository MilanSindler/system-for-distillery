using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Pálenice
{
    public partial class MainWindow : Form
    {
        private int Year
        {
            get => (int)YearUpDown.Value;
            set => YearUpDown.Value = value;
        }
        private Month Month
        {
            get => (Month)MonthComboBox.SelectedIndex;
            set => MonthComboBox.SelectedIndex = (int)value;
        }
        private Double Etanol
        {
            get => double.Parse(EtanolTextBox.Text.Replace(",", "."));
            set => EtanolTextBox.Text = value.ToString();
        }

        private string BirthNum
        {
            get => BirthNumTextBox.Text;
            set => BirthNumTextBox.Text = value;
        }
        private Record Record
        {
            get {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Zvol Položku", "Chyba", MessageBoxButtons.OK);
                    return null;
                }
                else
                    return (Record)listView1.SelectedItems[0].Tag;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            Year = DateTime.Now.Year;
            Month = (Month)DateTime.Now.Month - 1;
            EnableButtons();
        }

        private void UpdateUI()
        {
            listView1.Items.Clear();
            double count = 0;
            ManagerOfRecords.GetRecords(Year, Month).ForEach(x => { count += x.Etanol; listView1.Items.Add(GetListWievElement(x)); });
            AllLaaLabel.Text = count.ToString();
            EnableButtons();
        }

        private ListViewItem GetListWievElement(Record record)
        {
            ListViewItem item = new ListViewItem(record.Person.BirthNum);
            item.SubItems.Add(record.Person.Name);
            item.SubItems.Add(record.Person.Surname);
            item.SubItems.Add(record.Person.City);
            item.SubItems.Add(record.Person.PostalCode.ToString());
            item.SubItems.Add(record.Person.Street);
            item.SubItems.Add(record.Person.DescriptiveNumber);
            item.SubItems.Add(record.Etanol.ToString());
            item.Tag = record;
            return item;
        }

        private void EditPeopleMenuItem_Click(object sender, EventArgs e)
        {
            BirthNumDialog askDialog = new BirthNumDialog("Rodné číslo");
            if (askDialog.ShowDialog() == DialogResult.OK)
            {
                if (!ManagerOfPersons.Exist(askDialog.result))
                {
                    string message = "Rodné číslo není v databázi\nPřidat Nový záznam?";
                    if (MessageBox.Show(message, "Chyba", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        AddPersonForm AddDialog = new AddPersonForm(askDialog.result);
                        AddDialog.ShowDialog();
                    }
                    return;
                }
                AddPersonForm dialog = AddPersonForm.EditPerson(ManagerOfPersons.GetPerson(askDialog.result));
                if (dialog.ShowDialog() == DialogResult.OK)
                    UpdateUI();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Record == null || MessageBox.Show("Opravdu si přejete smazat záznam?", "Odebrat", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            ManagerOfRecords.Delete(Record);
            UpdateUI();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (Record == null)
                return;
            EditRecord dialog = new EditRecord(Record.Person.BirthNum, Record.Etanol);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!ManagerOfPersons.Exist(dialog.BirthNum))
                {
                    AddPersonForm addDialog = new AddPersonForm(dialog.BirthNum);
                    addDialog.ShowDialog();
                }
                ManagerOfRecords.Delete(Record);
                ManagerOfRecords.AddRecord(new Record(Year, Month, dialog.BirthNum, dialog.Etanol));
            }
            UpdateUI();
        }

        private void DeletePeopleMenuItem_Click(object sender, EventArgs e)
        {
            BirthNumDialog dialog = new BirthNumDialog("Rodné číslo");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Person person = ManagerOfPersons.GetPerson(dialog.result);
                if (ManagerOfPersons.Exist(dialog.result))
                {
                    ManagerOfPersons.Delete(person);
                    UpdateUI();
                }
                else
                {
                    MessageBox.Show("Neznámé číslo narození", "Chyba", MessageBoxButtons.OK);
                }

            }
            EnableButtons();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string message = "";
            message += Person.IsValidBirthNum(BirthNum) ? "" : "Špatné rodné číslo";
            message += double.TryParse(EtanolTextBox.Text.Replace(",", "."), out _) ? "" : "\nChybný údaj v etanolu";
            if (message.Length > 0)
            {
                MessageBox.Show(message, "Chyba", MessageBoxButtons.OK);
                return;
            }
            if (!ManagerOfPersons.Exist(BirthNum))
            {
                AddPersonForm dialog = new AddPersonForm(BirthNum);
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;
            }
            AddRecord(new Record(Year, Month, BirthNum, Etanol));
            BirthNumTextBox.Text = "";
            EtanolTextBox.Text = "";
            UpdateUI();
        }

        private void Save(object sender, EventArgs e)
        {
            ManagerOfPersons.Save();
            ManagerOfRecords.Save();
            MessageBox.Show("Úspěšně uloženo", "Uloženo", MessageBoxButtons.OK);
        }

        private void AddPeopleMenuItem_Click(object sender, EventArgs e)
        {
            AddPersonForm form = new AddPersonForm();
            if (form.ShowDialog() == DialogResult.OK)
                UpdateUI();
        }
        private void LookPeopleMenuItem_Click(object sender, EventArgs e)
        {
            ManagePeopleForm form = new ManagePeopleForm();
            form.ShowDialog();
            if (form.changed)
                UpdateUI();
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
            => Application.Exit();
        private void AddRecord(Record record)
            => ManagerOfRecords.AddRecord(record);
        private void Update_ListView(object sender, EventArgs e)
            => UpdateUI();

        private void ExportToolStripButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK ||
                openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            {
                try
                {
                    ExcelWorker.Export(ManagerOfRecords.GetRecords(Year, Month),
                        saveFileDialog1.FileName,
                        openFileDialog1.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Export se nezdařil: " + ex.Message, "Chyba", MessageBoxButtons.YesNo);
                }
            }
        }

        private void LoadToolStripButton_Click(object sender, EventArgs e)
        {
            DateSelect dialog = new DateSelect();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                ExcelWorker.Load(file, dialog.Year, dialog.Month).ForEach(x => ManagerOfRecords.AddRecord(x));
                UpdateUI();
            }
        }

        private void FindPeopleMenuItem_Click(object sender, EventArgs e)
        {
            BirthNumDialog askDialog = new BirthNumDialog("Rodné číslo");
            if (askDialog.ShowDialog() == DialogResult.OK)
            {
                Person person = ManagerOfPersons.GetPerson(askDialog.result);
                if (ManagerOfPersons.Exist(askDialog.result))
                {
                    string message = "Rodné číslo není v databázi\nPřidat Nový záznam?";
                    if (MessageBox.Show(message, "Chyba", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        (new PeopleInformForm(person)).ShowDialog();
                    }
                    else
                        return;
                }
                AddPersonForm dialog = AddPersonForm.EditPerson(person);
                dialog.ShowDialog();
            }
        }
        private void EnableButtons()
        {
            EditButton.Enabled = !(listView1.SelectedItems.Count == 0);
            DeleteButton.Enabled = !(listView1.SelectedItems.Count == 0);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
            => EnableButtons();

        private void YearUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }
    }
}
