
namespace Tablice_i_listy
{
    partial class WorldSeriesWinnerss
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
            this.TeamsBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TeamName = new System.Windows.Forms.Label();
            this.TeamWins = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamsBox
            // 
            this.TeamsBox.FormattingEnabled = true;
            this.TeamsBox.Location = new System.Drawing.Point(6, 19);
            this.TeamsBox.Name = "TeamsBox";
            this.TeamsBox.Size = new System.Drawing.Size(347, 303);
            this.TeamsBox.TabIndex = 0;
            this.TeamsBox.SelectedIndexChanged += new System.EventHandler(this.TeamsBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TeamsBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 338);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teams";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TeamWins);
            this.groupBox2.Controls.Add(this.TeamName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(386, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TeamInfo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "World Series wins";
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.BackColor = System.Drawing.SystemColors.Window;
            this.TeamName.Location = new System.Drawing.Point(135, 31);
            this.TeamName.MinimumSize = new System.Drawing.Size(150, 15);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(150, 15);
            this.TeamName.TabIndex = 2;
            // 
            // TeamWins
            // 
            this.TeamWins.AutoSize = true;
            this.TeamWins.BackColor = System.Drawing.SystemColors.Window;
            this.TeamWins.Location = new System.Drawing.Point(135, 56);
            this.TeamWins.MinimumSize = new System.Drawing.Size(150, 15);
            this.TeamWins.Name = "TeamWins";
            this.TeamWins.Size = new System.Drawing.Size(150, 15);
            this.TeamWins.TabIndex = 3;
            this.TeamWins.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TeamsBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label TeamWins;
        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

