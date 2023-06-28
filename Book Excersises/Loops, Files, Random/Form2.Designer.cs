
namespace B__Pętle__Pliki_i_losowość
{
    partial class Form2
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
            this.GeneratedNumbers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberCount = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Minimum = new System.Windows.Forms.TextBox();
            this.Maximum = new System.Windows.Forms.TextBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GeneratedNumbers
            // 
            this.GeneratedNumbers.FormattingEnabled = true;
            this.GeneratedNumbers.Location = new System.Drawing.Point(278, 135);
            this.GeneratedNumbers.Name = "GeneratedNumbers";
            this.GeneratedNumbers.Size = new System.Drawing.Size(246, 303);
            this.GeneratedNumbers.TabIndex = 0;
            this.GeneratedNumbers.SelectedIndexChanged += new System.EventHandler(this.GeneratedNumbers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ilość liczb do wygenerowania";
            // 
            // NumberCount
            // 
            this.NumberCount.Location = new System.Drawing.Point(456, 18);
            this.NumberCount.Name = "NumberCount";
            this.NumberCount.Size = new System.Drawing.Size(100, 20);
            this.NumberCount.TabIndex = 2;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(252, 95);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 3;
            this.Generate.Text = "Generuj";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(333, 95);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Zapisz";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(414, 95);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 5;
            this.Load.Text = "Wczytaj";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "max";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "min";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Minimum
            // 
            this.Minimum.Location = new System.Drawing.Point(326, 58);
            this.Minimum.MaximumSize = new System.Drawing.Size(30, 15);
            this.Minimum.MinimumSize = new System.Drawing.Size(4, 15);
            this.Minimum.Name = "Minimum";
            this.Minimum.Size = new System.Drawing.Size(30, 20);
            this.Minimum.TabIndex = 8;
            // 
            // Maximum
            // 
            this.Maximum.Location = new System.Drawing.Point(443, 59);
            this.Maximum.MaximumSize = new System.Drawing.Size(30, 15);
            this.Maximum.MinimumSize = new System.Drawing.Size(4, 15);
            this.Maximum.Name = "Maximum";
            this.Maximum.Size = new System.Drawing.Size(30, 20);
            this.Maximum.TabIndex = 9;
            // 
            // saveFile
            // 
            this.saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(499, 95);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Wyczyść";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.GeneratedNumbers);
            this.Controls.Add(this.Maximum);
            this.Controls.Add(this.Minimum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.NumberCount);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GeneratedNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberCount;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Minimum;
        private System.Windows.Forms.TextBox Maximum;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button Clear;
    }
}