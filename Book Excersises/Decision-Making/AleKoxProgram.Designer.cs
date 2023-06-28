
namespace Podejmowanie_decyzji_i_jakieś_tam_chujostwo
{
    partial class AleKoxProgram
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
            this.WorkshopsList = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AccomodationList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AccomodationPerDayCost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AccomodationTotalCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WorkshopsList
            // 
            this.WorkshopsList.ColumnWidth = 3;
            this.WorkshopsList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkshopsList.FormattingEnabled = true;
            this.WorkshopsList.ItemHeight = 17;
            this.WorkshopsList.Items.AddRange(new object[] {
            "Radzenie sobie ze stresem",
            "Zarządzanie czasem",
            "Umiejętność nadzorowania",
            "Negocjacje",
            "Jak poradzić sobie na rozmowie kwalifikacyjnej"});
            this.WorkshopsList.Location = new System.Drawing.Point(68, 40);
            this.WorkshopsList.Name = "WorkshopsList";
            this.WorkshopsList.Size = new System.Drawing.Size(300, 89);
            this.WorkshopsList.TabIndex = 0;
            this.WorkshopsList.SelectedIndexChanged += new System.EventHandler(this.WorkshopsList_SelectedIndexChanged);
            // 
            // AccomodationList
            // 
            this.AccomodationList.ColumnWidth = 3;
            this.AccomodationList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccomodationList.FormattingEnabled = true;
            this.AccomodationList.ItemHeight = 17;
            this.AccomodationList.Items.AddRange(new object[] {
            "Kraków",
            "Poznań",
            "Koszalin",
            "Gdańsk",
            "Gliwice",
            "Rzeszów"});
            this.AccomodationList.Location = new System.Drawing.Point(409, 40);
            this.AccomodationList.Name = "AccomodationList";
            this.AccomodationList.Size = new System.Drawing.Size(301, 89);
            this.AccomodationList.TabIndex = 1;
            this.AccomodationList.SelectedIndexChanged += new System.EventHandler(this.AccomodationList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Warsztaty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(409, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nocleg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(68, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Liczba Dni:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(68, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Koszt uczestnictwa: ";
            // 
            // DaysLabel
            // 
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.BackColor = System.Drawing.SystemColors.Window;
            this.DaysLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DaysLabel.Location = new System.Drawing.Point(209, 151);
            this.DaysLabel.MinimumSize = new System.Drawing.Size(75, 15);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(75, 17);
            this.DaysLabel.TabIndex = 6;
            this.DaysLabel.Click += new System.EventHandler(this.DaysLabel_Click);
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.BackColor = System.Drawing.SystemColors.Window;
            this.Cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cost.Location = new System.Drawing.Point(209, 185);
            this.Cost.MinimumSize = new System.Drawing.Size(75, 15);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(75, 17);
            this.Cost.TabIndex = 7;
            this.Cost.Click += new System.EventHandler(this.Cost_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(409, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Koszt Noclegu\r\n(za dzień)";
            // 
            // AccomodationPerDayCost
            // 
            this.AccomodationPerDayCost.AutoSize = true;
            this.AccomodationPerDayCost.BackColor = System.Drawing.SystemColors.Window;
            this.AccomodationPerDayCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccomodationPerDayCost.Location = new System.Drawing.Point(533, 153);
            this.AccomodationPerDayCost.MinimumSize = new System.Drawing.Size(75, 15);
            this.AccomodationPerDayCost.Name = "AccomodationPerDayCost";
            this.AccomodationPerDayCost.Size = new System.Drawing.Size(75, 17);
            this.AccomodationPerDayCost.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(409, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 45);
            this.label7.TabIndex = 10;
            this.label7.Text = "Koszt Łączny\r\nNoclegu\r\n\r\n";
            // 
            // AccomodationTotalCost
            // 
            this.AccomodationTotalCost.AutoSize = true;
            this.AccomodationTotalCost.BackColor = System.Drawing.SystemColors.Window;
            this.AccomodationTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccomodationTotalCost.Location = new System.Drawing.Point(533, 195);
            this.AccomodationTotalCost.MinimumSize = new System.Drawing.Size(75, 15);
            this.AccomodationTotalCost.Name = "AccomodationTotalCost";
            this.AccomodationTotalCost.Size = new System.Drawing.Size(75, 17);
            this.AccomodationTotalCost.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(234, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 56);
            this.label6.TabIndex = 12;
            this.label6.Text = "Koszt Łączny\r\n\r\n";
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.BackColor = System.Drawing.SystemColors.Window;
            this.TotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCost.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalCost.Location = new System.Drawing.Point(409, 264);
            this.TotalCost.MinimumSize = new System.Drawing.Size(100, 15);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(100, 30);
            this.TotalCost.TabIndex = 13;
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(350, 385);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 14;
            this.Quit.Text = "&Zakończ";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AccomodationTotalCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AccomodationPerDayCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccomodationList);
            this.Controls.Add(this.WorkshopsList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WorkshopsList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox AccomodationList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DaysLabel;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AccomodationPerDayCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label AccomodationTotalCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalCost;
        private System.Windows.Forms.Button Quit;
    }
}

