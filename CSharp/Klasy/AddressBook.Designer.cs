
namespace Klasy
{
    partial class AddressBook
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
            this.PeopleList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.TelNumber = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.LoadDial = new System.Windows.Forms.OpenFileDialog();
            this.SaveDial = new System.Windows.Forms.SaveFileDialog();
            this.ClearList = new System.Windows.Forms.Button();
            this.ClearAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PeopleList
            // 
            this.PeopleList.FormattingEnabled = true;
            this.PeopleList.ItemHeight = 15;
            this.PeopleList.Location = new System.Drawing.Point(12, 12);
            this.PeopleList.Name = "PeopleList";
            this.PeopleList.Size = new System.Drawing.Size(268, 364);
            this.PeopleList.Sorted = true;
            this.PeopleList.TabIndex = 0;
            this.PeopleList.SelectedIndexChanged += new System.EventHandler(this.PeopleList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearAdd);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.TelNumber);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.Surname);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(286, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Person";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(54, 161);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 10;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // TelNumber
            // 
            this.TelNumber.Location = new System.Drawing.Point(110, 117);
            this.TelNumber.Name = "TelNumber";
            this.TelNumber.Size = new System.Drawing.Size(100, 23);
            this.TelNumber.TabIndex = 7;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(110, 88);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 23);
            this.Email.TabIndex = 6;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(110, 59);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(100, 23);
            this.Surname.TabIndex = 5;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(110, 30);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 23);
            this.Name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone\r\nNumber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(29, 396);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(110, 396);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 11;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // LoadDial
            // 
            this.LoadDial.FileName = "openFileDialog1";
            // 
            // ClearList
            // 
            this.ClearList.Location = new System.Drawing.Point(191, 396);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(75, 23);
            this.ClearList.TabIndex = 12;
            this.ClearList.Text = "Clear";
            this.ClearList.UseVisualStyleBackColor = true;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // ClearAdd
            // 
            this.ClearAdd.Location = new System.Drawing.Point(135, 161);
            this.ClearAdd.Name = "ClearAdd";
            this.ClearAdd.Size = new System.Drawing.Size(75, 23);
            this.ClearAdd.TabIndex = 13;
            this.ClearAdd.Text = "Clear";
            this.ClearAdd.UseVisualStyleBackColor = true;
            this.ClearAdd.Click += new System.EventHandler(this.ClearAdd_Click);
            // 
            // AddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PeopleList);
            //this.Name = "AddressBook";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox TelNumber;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.OpenFileDialog LoadDial;
        private System.Windows.Forms.SaveFileDialog SaveDial;
        public System.Windows.Forms.ListBox PeopleList;
        private System.Windows.Forms.Button ClearAdd;
        private System.Windows.Forms.Button ClearList;
    }
}