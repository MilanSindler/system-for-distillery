
namespace Pálenice
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SystemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPeopleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPeopleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePeopleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindPeopleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LookPeopleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BirthNumCol = new System.Windows.Forms.ColumnHeader();
            this.NameCol = new System.Windows.Forms.ColumnHeader();
            this.SurnameCol = new System.Windows.Forms.ColumnHeader();
            this.CityCol = new System.Windows.Forms.ColumnHeader();
            this.PostalCodeCol = new System.Windows.Forms.ColumnHeader();
            this.StreetCol = new System.Windows.Forms.ColumnHeader();
            this.DescriptiveNumberCol = new System.Windows.Forms.ColumnHeader();
            this.EtanolCol = new System.Windows.Forms.ColumnHeader();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.AllLaaLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BirthNumTextBox = new System.Windows.Forms.TextBox();
            this.EtanolTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ShowClintsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ExportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LoadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.YearUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemMenuItem,
            this.PeopleMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SystemMenuItem
            // 
            this.SystemMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem,
            this.SaveMenuItem,
            this.ExitMenuItem});
            this.SystemMenuItem.Name = "SystemMenuItem";
            this.SystemMenuItem.Size = new System.Drawing.Size(70, 24);
            this.SystemMenuItem.Text = "System";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.LoadToolStripMenuItem.Text = "Načíst";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripButton_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(133, 26);
            this.SaveMenuItem.Text = "Uložit";
            this.SaveMenuItem.Click += new System.EventHandler(this.Save);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(133, 26);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // PeopleMenuItem
            // 
            this.PeopleMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPeopleMenuItem,
            this.EditPeopleMenuItem,
            this.DeletePeopleMenuItem,
            this.FindPeopleMenuItem,
            this.LookPeopleMenuItem});
            this.PeopleMenuItem.Name = "PeopleMenuItem";
            this.PeopleMenuItem.Size = new System.Drawing.Size(85, 24);
            this.PeopleMenuItem.Text = "Zákazníci";
            // 
            // AddPeopleMenuItem
            // 
            this.AddPeopleMenuItem.Name = "AddPeopleMenuItem";
            this.AddPeopleMenuItem.Size = new System.Drawing.Size(157, 26);
            this.AddPeopleMenuItem.Text = "Přidat";
            this.AddPeopleMenuItem.Click += new System.EventHandler(this.AddPeopleMenuItem_Click);
            // 
            // EditPeopleMenuItem
            // 
            this.EditPeopleMenuItem.Name = "EditPeopleMenuItem";
            this.EditPeopleMenuItem.Size = new System.Drawing.Size(157, 26);
            this.EditPeopleMenuItem.Text = "Upravit";
            this.EditPeopleMenuItem.Click += new System.EventHandler(this.EditPeopleMenuItem_Click);
            // 
            // DeletePeopleMenuItem
            // 
            this.DeletePeopleMenuItem.Name = "DeletePeopleMenuItem";
            this.DeletePeopleMenuItem.Size = new System.Drawing.Size(157, 26);
            this.DeletePeopleMenuItem.Text = "Odstranit";
            this.DeletePeopleMenuItem.Click += new System.EventHandler(this.DeletePeopleMenuItem_Click);
            // 
            // FindPeopleMenuItem
            // 
            this.FindPeopleMenuItem.Name = "FindPeopleMenuItem";
            this.FindPeopleMenuItem.Size = new System.Drawing.Size(157, 26);
            this.FindPeopleMenuItem.Text = "Vyhledat";
            this.FindPeopleMenuItem.Click += new System.EventHandler(this.FindPeopleMenuItem_Click);
            // 
            // LookPeopleMenuItem
            // 
            this.LookPeopleMenuItem.Name = "LookPeopleMenuItem";
            this.LookPeopleMenuItem.Size = new System.Drawing.Size(157, 26);
            this.LookPeopleMenuItem.Text = "Procházet";
            this.LookPeopleMenuItem.Click += new System.EventHandler(this.LookPeopleMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BirthNumCol,
            this.NameCol,
            this.SurnameCol,
            this.CityCol,
            this.PostalCodeCol,
            this.StreetCol,
            this.DescriptiveNumberCol,
            this.EtanolCol});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 136);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(785, 326);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // BirthNumCol
            // 
            this.BirthNumCol.Text = "Rodné číslo";
            this.BirthNumCol.Width = 100;
            // 
            // NameCol
            // 
            this.NameCol.Text = "Jméno";
            this.NameCol.Width = 90;
            // 
            // SurnameCol
            // 
            this.SurnameCol.Text = "Příjmení";
            this.SurnameCol.Width = 90;
            // 
            // CityCol
            // 
            this.CityCol.Text = "Obec";
            this.CityCol.Width = 170;
            // 
            // PostalCodeCol
            // 
            this.PostalCodeCol.Text = "PSČ";
            // 
            // StreetCol
            // 
            this.StreetCol.Text = "Ulice";
            this.StreetCol.Width = 90;
            // 
            // DescriptiveNumberCol
            // 
            this.DescriptiveNumberCol.Text = "Číslo Popisné";
            this.DescriptiveNumberCol.Width = 100;
            // 
            // EtanolCol
            // 
            this.EtanolCol.Text = "Etanol[L]";
            this.EtanolCol.Width = 75;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.AllLaaLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(809, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 20);
            this.toolStripStatusLabel1.Text = "Celkem Laa:";
            // 
            // AllLaaLabel
            // 
            this.AllLaaLabel.Name = "AllLaaLabel";
            this.AllLaaLabel.Size = new System.Drawing.Size(17, 20);
            this.AllLaaLabel.Text = "0";
            // 
            // BirthNumTextBox
            // 
            this.BirthNumTextBox.Location = new System.Drawing.Point(104, 99);
            this.BirthNumTextBox.Name = "BirthNumTextBox";
            this.BirthNumTextBox.Size = new System.Drawing.Size(130, 27);
            this.BirthNumTextBox.TabIndex = 4;
            // 
            // EtanolTextBox
            // 
            this.EtanolTextBox.Location = new System.Drawing.Point(305, 102);
            this.EtanolTextBox.Name = "EtanolTextBox";
            this.EtanolTextBox.Size = new System.Drawing.Size(130, 27);
            this.EtanolTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rodné číslo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ethanol";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(441, 102);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 27);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Přidat";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.CausesValidation = false;
            this.DeleteButton.Location = new System.Drawing.Point(557, 102);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(110, 27);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Odebrat";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rok";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(240, 69);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(47, 20);
            this.label.TabIndex = 12;
            this.label.Text = "Měsíc";
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
            "Leden",
            "Únor",
            "Březen",
            "Duben",
            "Květen",
            "Červen",
            "Červenec",
            "Srpen",
            "Září",
            "Říjen",
            "Listopad",
            "Prosinec"});
            this.MonthComboBox.Location = new System.Drawing.Point(305, 64);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(130, 28);
            this.MonthComboBox.TabIndex = 13;
            this.MonthComboBox.SelectedIndexChanged += new System.EventHandler(this.Update_ListView);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowClintsToolStripButton,
            this.ExportToolStripButton,
            this.LoadToolStripButton,
            this.SaveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(809, 27);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ShowClintsToolStripButton
            // 
            this.ShowClintsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ShowClintsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowClintsToolStripButton.Image")));
            this.ShowClintsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowClintsToolStripButton.Name = "ShowClintsToolStripButton";
            this.ShowClintsToolStripButton.Size = new System.Drawing.Size(55, 24);
            this.ShowClintsToolStripButton.Text = "Klienti";
            this.ShowClintsToolStripButton.Click += new System.EventHandler(this.LookPeopleMenuItem_Click);
            // 
            // ExportToolStripButton
            // 
            this.ExportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportToolStripButton.Image")));
            this.ExportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToolStripButton.Name = "ExportToolStripButton";
            this.ExportToolStripButton.Size = new System.Drawing.Size(85, 24);
            this.ExportToolStripButton.Text = "Exportovat";
            this.ExportToolStripButton.Click += new System.EventHandler(this.ExportToolStripButton_Click);
            // 
            // LoadToolStripButton
            // 
            this.LoadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoadToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadToolStripButton.Image")));
            this.LoadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadToolStripButton.Name = "LoadToolStripButton";
            this.LoadToolStripButton.Size = new System.Drawing.Size(54, 24);
            this.LoadToolStripButton.Text = "Načíst";
            this.LoadToolStripButton.Click += new System.EventHandler(this.LoadToolStripButton_Click);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(52, 24);
            this.SaveToolStripButton.Text = "Uložit";
            this.SaveToolStripButton.Click += new System.EventHandler(this.Save);
            // 
            // EditButton
            // 
            this.EditButton.CausesValidation = false;
            this.EditButton.Location = new System.Drawing.Point(673, 103);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(110, 27);
            this.EditButton.TabIndex = 15;
            this.EditButton.Text = "Upravit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // YearUpDown
            // 
            this.YearUpDown.Location = new System.Drawing.Point(104, 66);
            this.YearUpDown.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.YearUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.YearUpDown.Name = "YearUpDown";
            this.YearUpDown.Size = new System.Drawing.Size(130, 27);
            this.YearUpDown.TabIndex = 16;
            this.YearUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.YearUpDown.ValueChanged += new System.EventHandler(this.YearUpDown_ValueChanged);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 491);
            this.Controls.Add(this.YearUpDown);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EtanolTextBox);
            this.Controls.Add(this.BirthNumTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hustopečská Pálenice";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SystemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PeopleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPeopleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditPeopleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletePeopleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindPeopleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LookPeopleMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel AllLaaLabel;
        private System.Windows.Forms.TextBox BirthNumTextBox;
        private System.Windows.Forms.TextBox EtanolTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ColumnHeader BirthNumCol;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader PostalCode;
        private System.Windows.Forms.ColumnHeader Street;
        private System.Windows.Forms.ColumnHeader DescriptiveNumber;
        private System.Windows.Forms.ColumnHeader EtanolCol;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ShowClintsToolStripButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ExportToolStripButton;
        private System.Windows.Forms.ToolStripButton LoadToolStripButton;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColumnHeader SurnameCol;
        private System.Windows.Forms.ColumnHeader CityCol;
        private System.Windows.Forms.ColumnHeader PostalCodeCol;
        private System.Windows.Forms.ColumnHeader StreetCol;
        private System.Windows.Forms.ColumnHeader DescriptiveNumberCol;
        private System.Windows.Forms.NumericUpDown YearUpDown;
    }
}

