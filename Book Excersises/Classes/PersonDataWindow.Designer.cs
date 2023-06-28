
namespace Klasy
{
    partial class PersonDataWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.TelNumber = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone Number";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.SystemColors.Window;
            this.Name.Location = new System.Drawing.Point(251, 55);
            this.Name.MinimumSize = new System.Drawing.Size(150, 15);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(150, 15);
            this.Name.TabIndex = 4;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.BackColor = System.Drawing.SystemColors.Window;
            this.Surname.Location = new System.Drawing.Point(251, 81);
            this.Surname.MinimumSize = new System.Drawing.Size(150, 15);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(150, 15);
            this.Surname.TabIndex = 5;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.SystemColors.Window;
            this.Email.Location = new System.Drawing.Point(251, 106);
            this.Email.MinimumSize = new System.Drawing.Size(150, 15);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(150, 15);
            this.Email.TabIndex = 6;
            // 
            // TelNumber
            // 
            this.TelNumber.AutoSize = true;
            this.TelNumber.BackColor = System.Drawing.SystemColors.Window;
            this.TelNumber.Location = new System.Drawing.Point(251, 132);
            this.TelNumber.MinimumSize = new System.Drawing.Size(150, 15);
            this.TelNumber.Name = "TelNumber";
            this.TelNumber.Size = new System.Drawing.Size(150, 15);
            this.TelNumber.TabIndex = 7;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(195, 172);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 8;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // PersonDataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 234);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.TelNumber);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            //this.Name = "PersonDataWindow";
            this.Text = "Person Data";
            this.Load += new System.EventHandler(this.PersonDataWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label TelNumber;
        private System.Windows.Forms.Label NamePDW;
        private System.Windows.Forms.Button Close;
    }
}