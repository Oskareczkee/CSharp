
namespace Przetwarzanie_danych
{
    partial class LegiaWarszawaIncomeCalculator
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
            this.TicketSell = new System.Windows.Forms.GroupBox();
            this.StrefaCText = new System.Windows.Forms.TextBox();
            this.StrefaBText = new System.Windows.Forms.TextBox();
            this.StrefaAText = new System.Windows.Forms.TextBox();
            this.StrefaC = new System.Windows.Forms.Label();
            this.StrefaB = new System.Windows.Forms.Label();
            this.StrefaA = new System.Windows.Forms.Label();
            this.TicketSellDescription = new System.Windows.Forms.TextBox();
            this.IncomeGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalIncomeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SiteCIncomeLabel = new System.Windows.Forms.Label();
            this.SiteBIncomeLabel = new System.Windows.Forms.Label();
            this.SiteAIncomeLabel = new System.Windows.Forms.Label();
            this.SiteAIncome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalculateIncomeButton = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.TicketSell.SuspendLayout();
            this.IncomeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketSell
            // 
            this.TicketSell.Controls.Add(this.StrefaCText);
            this.TicketSell.Controls.Add(this.StrefaBText);
            this.TicketSell.Controls.Add(this.StrefaAText);
            this.TicketSell.Controls.Add(this.StrefaC);
            this.TicketSell.Controls.Add(this.StrefaB);
            this.TicketSell.Controls.Add(this.StrefaA);
            this.TicketSell.Controls.Add(this.TicketSellDescription);
            this.TicketSell.Location = new System.Drawing.Point(44, 34);
            this.TicketSell.Name = "TicketSell";
            this.TicketSell.Size = new System.Drawing.Size(299, 252);
            this.TicketSell.TabIndex = 0;
            this.TicketSell.TabStop = false;
            this.TicketSell.Text = "Sprzedaż biletów";
            // 
            // StrefaCText
            // 
            this.StrefaCText.Location = new System.Drawing.Point(112, 196);
            this.StrefaCText.Name = "StrefaCText";
            this.StrefaCText.Size = new System.Drawing.Size(100, 20);
            this.StrefaCText.TabIndex = 6;
            // 
            // StrefaBText
            // 
            this.StrefaBText.Location = new System.Drawing.Point(112, 155);
            this.StrefaBText.Name = "StrefaBText";
            this.StrefaBText.Size = new System.Drawing.Size(100, 20);
            this.StrefaBText.TabIndex = 5;
            // 
            // StrefaAText
            // 
            this.StrefaAText.Location = new System.Drawing.Point(112, 113);
            this.StrefaAText.Name = "StrefaAText";
            this.StrefaAText.Size = new System.Drawing.Size(100, 20);
            this.StrefaAText.TabIndex = 4;
            // 
            // StrefaC
            // 
            this.StrefaC.AutoSize = true;
            this.StrefaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StrefaC.Location = new System.Drawing.Point(16, 196);
            this.StrefaC.Name = "StrefaC";
            this.StrefaC.Size = new System.Drawing.Size(59, 17);
            this.StrefaC.TabIndex = 3;
            this.StrefaC.Text = "Strefa C";
            this.StrefaC.Click += new System.EventHandler(this.label2_Click);
            // 
            // StrefaB
            // 
            this.StrefaB.AutoSize = true;
            this.StrefaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StrefaB.Location = new System.Drawing.Point(16, 155);
            this.StrefaB.Name = "StrefaB";
            this.StrefaB.Size = new System.Drawing.Size(59, 17);
            this.StrefaB.TabIndex = 2;
            this.StrefaB.Text = "Strefa B";
            // 
            // StrefaA
            // 
            this.StrefaA.AutoSize = true;
            this.StrefaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StrefaA.Location = new System.Drawing.Point(16, 113);
            this.StrefaA.Name = "StrefaA";
            this.StrefaA.Size = new System.Drawing.Size(59, 17);
            this.StrefaA.TabIndex = 1;
            this.StrefaA.Text = "Strefa A";
            // 
            // TicketSellDescription
            // 
            this.TicketSellDescription.Location = new System.Drawing.Point(19, 19);
            this.TicketSellDescription.Multiline = true;
            this.TicketSellDescription.Name = "TicketSellDescription";
            this.TicketSellDescription.ReadOnly = true;
            this.TicketSellDescription.Size = new System.Drawing.Size(158, 53);
            this.TicketSellDescription.TabIndex = 0;
            this.TicketSellDescription.Text = "Podaj liczbę sprzedanych biletów w poszczególnych strefach";
            // 
            // IncomeGroupBox
            // 
            this.IncomeGroupBox.Controls.Add(this.TotalIncomeLabel);
            this.IncomeGroupBox.Controls.Add(this.label4);
            this.IncomeGroupBox.Controls.Add(this.SiteCIncomeLabel);
            this.IncomeGroupBox.Controls.Add(this.SiteBIncomeLabel);
            this.IncomeGroupBox.Controls.Add(this.SiteAIncomeLabel);
            this.IncomeGroupBox.Controls.Add(this.SiteAIncome);
            this.IncomeGroupBox.Controls.Add(this.label3);
            this.IncomeGroupBox.Controls.Add(this.label2);
            this.IncomeGroupBox.Controls.Add(this.label1);
            this.IncomeGroupBox.Location = new System.Drawing.Point(443, 43);
            this.IncomeGroupBox.Name = "IncomeGroupBox";
            this.IncomeGroupBox.Size = new System.Drawing.Size(254, 243);
            this.IncomeGroupBox.TabIndex = 1;
            this.IncomeGroupBox.TabStop = false;
            this.IncomeGroupBox.Text = "Wpływy ze sprzedaży";
            this.IncomeGroupBox.Enter += new System.EventHandler(this.IncomeGroupBox_Enter);
            // 
            // TotalIncomeLabel
            // 
            this.TotalIncomeLabel.AutoSize = true;
            this.TotalIncomeLabel.BackColor = System.Drawing.SystemColors.Window;
            this.TotalIncomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalIncomeLabel.Location = new System.Drawing.Point(106, 215);
            this.TotalIncomeLabel.MaximumSize = new System.Drawing.Size(120, 20);
            this.TotalIncomeLabel.MinimumSize = new System.Drawing.Size(120, 20);
            this.TotalIncomeLabel.Name = "TotalIncomeLabel";
            this.TotalIncomeLabel.Size = new System.Drawing.Size(120, 20);
            this.TotalIncomeLabel.TabIndex = 15;
            this.TotalIncomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(16, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Razem";
            // 
            // SiteCIncomeLabel
            // 
            this.SiteCIncomeLabel.AutoSize = true;
            this.SiteCIncomeLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SiteCIncomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SiteCIncomeLabel.Location = new System.Drawing.Point(107, 179);
            this.SiteCIncomeLabel.MaximumSize = new System.Drawing.Size(120, 20);
            this.SiteCIncomeLabel.MinimumSize = new System.Drawing.Size(120, 20);
            this.SiteCIncomeLabel.Name = "SiteCIncomeLabel";
            this.SiteCIncomeLabel.Size = new System.Drawing.Size(120, 20);
            this.SiteCIncomeLabel.TabIndex = 13;
            this.SiteCIncomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SiteBIncomeLabel
            // 
            this.SiteBIncomeLabel.AutoSize = true;
            this.SiteBIncomeLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SiteBIncomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SiteBIncomeLabel.Location = new System.Drawing.Point(107, 136);
            this.SiteBIncomeLabel.MaximumSize = new System.Drawing.Size(120, 20);
            this.SiteBIncomeLabel.MinimumSize = new System.Drawing.Size(120, 20);
            this.SiteBIncomeLabel.Name = "SiteBIncomeLabel";
            this.SiteBIncomeLabel.Size = new System.Drawing.Size(120, 20);
            this.SiteBIncomeLabel.TabIndex = 12;
            this.SiteBIncomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SiteBIncomeLabel.Click += new System.EventHandler(this.SiteBIncomeLabel_Click);
            // 
            // SiteAIncomeLabel
            // 
            this.SiteAIncomeLabel.AutoSize = true;
            this.SiteAIncomeLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SiteAIncomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SiteAIncomeLabel.Location = new System.Drawing.Point(106, 94);
            this.SiteAIncomeLabel.MaximumSize = new System.Drawing.Size(120, 20);
            this.SiteAIncomeLabel.MinimumSize = new System.Drawing.Size(120, 20);
            this.SiteAIncomeLabel.Name = "SiteAIncomeLabel";
            this.SiteAIncomeLabel.Size = new System.Drawing.Size(120, 20);
            this.SiteAIncomeLabel.TabIndex = 11;
            this.SiteAIncomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SiteAIncomeLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // SiteAIncome
            // 
            this.SiteAIncome.AutoSize = true;
            this.SiteAIncome.Location = new System.Drawing.Point(139, 113);
            this.SiteAIncome.Name = "SiteAIncome";
            this.SiteAIncome.Size = new System.Drawing.Size(0, 13);
            this.SiteAIncome.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(16, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Strefa C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Strefa B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Strefa A";
            // 
            // CalculateIncomeButton
            // 
            this.CalculateIncomeButton.Location = new System.Drawing.Point(115, 365);
            this.CalculateIncomeButton.Name = "CalculateIncomeButton";
            this.CalculateIncomeButton.Size = new System.Drawing.Size(141, 32);
            this.CalculateIncomeButton.TabIndex = 2;
            this.CalculateIncomeButton.Text = "&Oblicz Wpływy";
            this.CalculateIncomeButton.UseVisualStyleBackColor = true;
            this.CalculateIncomeButton.Click += new System.EventHandler(this.CalculateIncomeButton_Click);
            // 
            // Clear
            // 
            this.Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Clear.Location = new System.Drawing.Point(336, 365);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(141, 32);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "&Wyczyść";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(543, 365);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(141, 32);
            this.Quit.TabIndex = 4;
            this.Quit.Text = "&Zakończ";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // LegiaWarszawaIncomeCalculator
            // 
            this.AcceptButton = this.CalculateIncomeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Clear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.CalculateIncomeButton);
            this.Controls.Add(this.IncomeGroupBox);
            this.Controls.Add(this.TicketSell);
            this.Name = "LegiaWarszawaIncomeCalculator";
            this.Text = "Form1";
            this.TicketSell.ResumeLayout(false);
            this.TicketSell.PerformLayout();
            this.IncomeGroupBox.ResumeLayout(false);
            this.IncomeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TicketSell;
        private System.Windows.Forms.Label StrefaC;
        private System.Windows.Forms.Label StrefaB;
        private System.Windows.Forms.Label StrefaA;
        private System.Windows.Forms.TextBox TicketSellDescription;
        private System.Windows.Forms.TextBox StrefaCText;
        private System.Windows.Forms.TextBox StrefaBText;
        private System.Windows.Forms.TextBox StrefaAText;
        private System.Windows.Forms.GroupBox IncomeGroupBox;
        private System.Windows.Forms.Label SiteAIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SiteAIncomeLabel;
        private System.Windows.Forms.Label SiteCIncomeLabel;
        private System.Windows.Forms.Label SiteBIncomeLabel;
        private System.Windows.Forms.Button CalculateIncomeButton;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Label TotalIncomeLabel;
        private System.Windows.Forms.Label label4;
    }
}

