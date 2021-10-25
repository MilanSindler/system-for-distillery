
namespace Pálenice
{
    partial class EditRecord
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BirthNumTextBox = new System.Windows.Forms.TextBox();
            this.EtanolTextBox = new System.Windows.Forms.TextBox();
            this.EditPersonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(70, 75);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(94, 29);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(195, 75);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 29);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rodné Číslo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Etanol[litry]";
            // 
            // BirthNumTextBox
            // 
            this.BirthNumTextBox.Location = new System.Drawing.Point(106, 9);
            this.BirthNumTextBox.Name = "BirthNumTextBox";
            this.BirthNumTextBox.Size = new System.Drawing.Size(125, 27);
            this.BirthNumTextBox.TabIndex = 4;
            // 
            // EtanolTextBox
            // 
            this.EtanolTextBox.Location = new System.Drawing.Point(106, 42);
            this.EtanolTextBox.Name = "EtanolTextBox";
            this.EtanolTextBox.Size = new System.Drawing.Size(125, 27);
            this.EtanolTextBox.TabIndex = 5;
            // 
            // EditPersonButton
            // 
            this.EditPersonButton.Location = new System.Drawing.Point(237, 12);
            this.EditPersonButton.Name = "EditPersonButton";
            this.EditPersonButton.Size = new System.Drawing.Size(94, 50);
            this.EditPersonButton.TabIndex = 6;
            this.EditPersonButton.Text = "Upravit Klienta";
            this.EditPersonButton.UseVisualStyleBackColor = true;
            this.EditPersonButton.Click += new System.EventHandler(this.EditPersonButton_Click);
            // 
            // EditRecord
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 110);
            this.Controls.Add(this.EditPersonButton);
            this.Controls.Add(this.EtanolTextBox);
            this.Controls.Add(this.BirthNumTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditRecord";
            this.Enter += new System.EventHandler(this.OKButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BirthNumTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox EtanolTextBox;
        private System.Windows.Forms.Button EditPersonButton;
    }
}