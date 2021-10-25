
namespace Pálenice
{
    partial class ManagePeopleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BirthNumCol = new System.Windows.Forms.ColumnHeader();
            this.NameCol = new System.Windows.Forms.ColumnHeader();
            this.SurnameCol = new System.Windows.Forms.ColumnHeader();
            this.CityCol = new System.Windows.Forms.ColumnHeader();
            this.PostalCodeCol = new System.Windows.Forms.ColumnHeader();
            this.StreetCol = new System.Windows.Forms.ColumnHeader();
            this.DescriptiveNumberCol = new System.Windows.Forms.ColumnHeader();
            this.ShowPersonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CloseButton.Location = new System.Drawing.Point(537, 391);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(94, 29);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Zavřít";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(8, 391);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Přidat";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(108, 391);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(94, 29);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Upravit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(308, 391);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(94, 29);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Odebrat";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.DescriptiveNumberCol});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(624, 373);
            this.listView1.TabIndex = 5;
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
            this.CityCol.Width = 90;
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
            // ShowPersonButton
            // 
            this.ShowPersonButton.Location = new System.Drawing.Point(208, 391);
            this.ShowPersonButton.Name = "ShowPersonButton";
            this.ShowPersonButton.Size = new System.Drawing.Size(94, 29);
            this.ShowPersonButton.TabIndex = 6;
            this.ShowPersonButton.Text = "Detaily";
            this.ShowPersonButton.UseVisualStyleBackColor = true;
            this.ShowPersonButton.Click += new System.EventHandler(this.ShowPersonButton_Click);
            // 
            // ManagePeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 437);
            this.Controls.Add(this.ShowPersonButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagePeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManagePeopleForm";
            this.Enter += new System.EventHandler(this.ManagePeopleForm_Enter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader BirthNum;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader PostalCode;
        private System.Windows.Forms.ColumnHeader Street;
        private System.Windows.Forms.ColumnHeader DescriptiveNumber;
        private System.Windows.Forms.Button ShowPersonButton;
        private System.Windows.Forms.ColumnHeader BirthNumCol;
        private System.Windows.Forms.ColumnHeader SurnameCol;
        private System.Windows.Forms.ColumnHeader CityCol;
        private System.Windows.Forms.ColumnHeader PostalCodeCol;
        private System.Windows.Forms.ColumnHeader StreetCol;
        private System.Windows.Forms.ColumnHeader DescriptiveNumberCol;
    }
}