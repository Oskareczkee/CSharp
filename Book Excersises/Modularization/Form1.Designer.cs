
namespace Modularyzacja
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Oil = new System.Windows.Forms.CheckBox();
            this.Lubrication = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GearboxCheck = new System.Windows.Forms.CheckBox();
            this.CoolerCheck = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MufflerReplacement = new System.Windows.Forms.CheckBox();
            this.VehicleInspection = new System.Windows.Forms.CheckBox();
            this.WheelBalance = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SpareParts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkTime = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SparePartsSum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ServicesAndLabor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SparePartsTax = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lubrication);
            this.groupBox1.Controls.Add(this.Oil);
            this.groupBox1.Location = new System.Drawing.Point(45, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Olej i smarowanie";
            // 
            // Oil
            // 
            this.Oil.AutoSize = true;
            this.Oil.Location = new System.Drawing.Point(22, 20);
            this.Oil.Name = "Oil";
            this.Oil.Size = new System.Drawing.Size(143, 17);
            this.Oil.TabIndex = 0;
            this.Oil.Text = "Wymiana oleju (26,00 zł)";
            this.Oil.UseVisualStyleBackColor = true;
            this.Oil.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Lubrication
            // 
            this.Lubrication.AutoSize = true;
            this.Lubrication.Location = new System.Drawing.Point(22, 43);
            this.Lubrication.Name = "Lubrication";
            this.Lubrication.Size = new System.Drawing.Size(132, 17);
            this.Lubrication.TabIndex = 1;
            this.Lubrication.Text = "Smarowanie (18,00 zł)";
            this.Lubrication.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GearboxCheck);
            this.groupBox2.Controls.Add(this.CoolerCheck);
            this.groupBox2.Location = new System.Drawing.Point(318, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sprawdzenie";
            // 
            // GearboxCheck
            // 
            this.GearboxCheck.AutoSize = true;
            this.GearboxCheck.Location = new System.Drawing.Point(22, 43);
            this.GearboxCheck.Name = "GearboxCheck";
            this.GearboxCheck.Size = new System.Drawing.Size(207, 17);
            this.GearboxCheck.TabIndex = 1;
            this.GearboxCheck.Text = "Sprawdzenie skrzyni biegów (80,00 zł)";
            this.GearboxCheck.UseVisualStyleBackColor = true;
            // 
            // CoolerCheck
            // 
            this.CoolerCheck.AutoSize = true;
            this.CoolerCheck.Location = new System.Drawing.Point(22, 20);
            this.CoolerCheck.Name = "CoolerCheck";
            this.CoolerCheck.Size = new System.Drawing.Size(185, 17);
            this.CoolerCheck.TabIndex = 0;
            this.CoolerCheck.Text = "Sprawdzenie chłodnicy (30,00 zł)";
            this.CoolerCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.WheelBalance);
            this.groupBox3.Controls.Add(this.MufflerReplacement);
            this.groupBox3.Controls.Add(this.VehicleInspection);
            this.groupBox3.Location = new System.Drawing.Point(45, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 102);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Różne";
            // 
            // MufflerReplacement
            // 
            this.MufflerReplacement.AutoSize = true;
            this.MufflerReplacement.Location = new System.Drawing.Point(22, 43);
            this.MufflerReplacement.Name = "MufflerReplacement";
            this.MufflerReplacement.Size = new System.Drawing.Size(162, 17);
            this.MufflerReplacement.TabIndex = 1;
            this.MufflerReplacement.Text = "Wymiana tłumika (100,00 zł)";
            this.MufflerReplacement.UseVisualStyleBackColor = true;
            // 
            // VehicleInspection
            // 
            this.VehicleInspection.AutoSize = true;
            this.VehicleInspection.Location = new System.Drawing.Point(22, 20);
            this.VehicleInspection.Name = "VehicleInspection";
            this.VehicleInspection.Size = new System.Drawing.Size(155, 17);
            this.VehicleInspection.TabIndex = 0;
            this.VehicleInspection.Text = "Przegląd pojazdu (15,00 zł)";
            this.VehicleInspection.UseVisualStyleBackColor = true;
            // 
            // WheelBalance
            // 
            this.WheelBalance.AutoSize = true;
            this.WheelBalance.Location = new System.Drawing.Point(22, 66);
            this.WheelBalance.Name = "WheelBalance";
            this.WheelBalance.Size = new System.Drawing.Size(148, 17);
            this.WheelBalance.TabIndex = 2;
            this.WheelBalance.Text = "Wyważanie kół (20,00 zł)";
            this.WheelBalance.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.WorkTime);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.SpareParts);
            this.groupBox4.Location = new System.Drawing.Point(302, 145);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 102);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Części zamienne i robocizna";
            // 
            // SpareParts
            // 
            this.SpareParts.Location = new System.Drawing.Point(102, 20);
            this.SpareParts.Name = "SpareParts";
            this.SpareParts.Size = new System.Drawing.Size(100, 20);
            this.SpareParts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Części zamienne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 56);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Robocizna";
            // 
            // WorkTime
            // 
            this.WorkTime.Location = new System.Drawing.Point(102, 53);
            this.WorkTime.Name = "WorkTime";
            this.WorkTime.Size = new System.Drawing.Size(100, 20);
            this.WorkTime.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Total);
            this.groupBox5.Controls.Add(this.SparePartsTax);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.SparePartsSum);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.ServicesAndLabor);
            this.groupBox5.Location = new System.Drawing.Point(45, 267);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 161);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Części zamienne i robocizna";
            // 
            // SparePartsSum
            // 
            this.SparePartsSum.Location = new System.Drawing.Point(145, 53);
            this.SparePartsSum.Name = "SparePartsSum";
            this.SparePartsSum.ReadOnly = true;
            this.SparePartsSum.Size = new System.Drawing.Size(100, 20);
            this.SparePartsSum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 56);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Części zamienne";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Usługi i robocizna";
            // 
            // ServicesAndLabor
            // 
            this.ServicesAndLabor.Location = new System.Drawing.Point(145, 21);
            this.ServicesAndLabor.Name = "ServicesAndLabor";
            this.ServicesAndLabor.ReadOnly = true;
            this.ServicesAndLabor.Size = new System.Drawing.Size(100, 20);
            this.ServicesAndLabor.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 90);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Podatek (części zamienne)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 123);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Razem";
            // 
            // SparePartsTax
            // 
            this.SparePartsTax.Location = new System.Drawing.Point(145, 87);
            this.SparePartsTax.Name = "SparePartsTax";
            this.SparePartsTax.ReadOnly = true;
            this.SparePartsTax.Size = new System.Drawing.Size(100, 20);
            this.SparePartsTax.TabIndex = 6;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(145, 120);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(100, 20);
            this.Total.TabIndex = 7;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(180, 449);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Oblicz";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(273, 449);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Wyczyść";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(371, 449);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 8;
            this.Quit.Text = "Zakończ";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 495);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Lubrication;
        private System.Windows.Forms.CheckBox Oil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox GearboxCheck;
        private System.Windows.Forms.CheckBox CoolerCheck;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox WheelBalance;
        private System.Windows.Forms.CheckBox MufflerReplacement;
        private System.Windows.Forms.CheckBox VehicleInspection;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox WorkTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SpareParts;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.TextBox SparePartsTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SparePartsSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ServicesAndLabor;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Quit;
    }
}

