
namespace Klasy
{
    partial class AccCalculator
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
            this.Numero0 = new System.Windows.Forms.RadioButton();
            this.AccomodationList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Numero1 = new System.Windows.Forms.RadioButton();
            this.Numero3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.AlimentationButtons = new System.Windows.Forms.GroupBox();
            this.AlimentationButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // Numero0
            // 
            this.Numero0.AutoSize = true;
            this.Numero0.Location = new System.Drawing.Point(14, 22);
            this.Numero0.Name = "Numero0";
            this.Numero0.Size = new System.Drawing.Size(100, 19);
            this.Numero0.TabIndex = 0;
            this.Numero0.TabStop = true;
            this.Numero0.Tag = "0";
            this.Numero0.Text = "7 Dishes/week";
            this.Numero0.UseVisualStyleBackColor = true;
            this.Numero0.CheckedChanged += new System.EventHandler(this.Numero0_CheckedChanged);
            // 
            // AccomodationList
            // 
            this.AccomodationList.FormattingEnabled = true;
            this.AccomodationList.ItemHeight = 15;
            this.AccomodationList.Items.AddRange(new object[] {
            "Allen Hall",
            "Pike Hall",
            "Farthing Hall",
            "University Suites"});
            this.AccomodationList.Location = new System.Drawing.Point(70, 57);
            this.AccomodationList.Name = "AccomodationList";
            this.AccomodationList.Size = new System.Drawing.Size(258, 259);
            this.AccomodationList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Accomodation";
            // 
            // Numero1
            // 
            this.Numero1.AutoSize = true;
            this.Numero1.Location = new System.Drawing.Point(14, 47);
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(106, 19);
            this.Numero1.TabIndex = 3;
            this.Numero1.TabStop = true;
            this.Numero1.Tag = "1";
            this.Numero1.Text = "14 Dishes/week";
            this.Numero1.UseVisualStyleBackColor = true;
            this.Numero1.CheckedChanged += new System.EventHandler(this.Numero0_CheckedChanged);
            // 
            // Numero3
            // 
            this.Numero3.AutoSize = true;
            this.Numero3.Location = new System.Drawing.Point(14, 72);
            this.Numero3.Name = "Numero3";
            this.Numero3.Size = new System.Drawing.Size(114, 19);
            this.Numero3.TabIndex = 4;
            this.Numero3.TabStop = true;
            this.Numero3.Tag = "2";
            this.Numero3.Text = "Unlimited Dishes";
            this.Numero3.UseVisualStyleBackColor = true;
            this.Numero3.CheckedChanged += new System.EventHandler(this.Numero0_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(388, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alimentation";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(388, 163);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // AlimentationButtons
            // 
            this.AlimentationButtons.Controls.Add(this.Numero0);
            this.AlimentationButtons.Controls.Add(this.Numero1);
            this.AlimentationButtons.Controls.Add(this.Numero3);
            this.AlimentationButtons.Location = new System.Drawing.Point(388, 57);
            this.AlimentationButtons.Name = "AlimentationButtons";
            this.AlimentationButtons.Size = new System.Drawing.Size(200, 100);
            this.AlimentationButtons.TabIndex = 7;
            this.AlimentationButtons.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AlimentationButtons);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccomodationList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AlimentationButtons.ResumeLayout(false);
            this.AlimentationButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Numero0;
        private System.Windows.Forms.ListBox AccomodationList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Numero1;
        private System.Windows.Forms.RadioButton Numero3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.GroupBox AlimentationButtons;
    }
}

