
namespace B__Pętle__Pliki_i_losowość
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
            this.Data = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.INOO = new System.Windows.Forms.TextBox();
            this.DailyGrow = new System.Windows.Forms.TextBox();
            this.Days = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.AllowUserToAddRows = false;
            this.Data.AllowUserToDeleteRows = false;
            this.Data.AllowUserToResizeColumns = false;
            this.Data.AllowUserToResizeRows = false;
            this.Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.APS});
            this.Data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Data.GridColor = System.Drawing.Color.Indigo;
            this.Data.Location = new System.Drawing.Point(55, 70);
            this.Data.MaximumSize = new System.Drawing.Size(350, 250);
            this.Data.MinimumSize = new System.Drawing.Size(100, 20);
            this.Data.Name = "Data";
            this.Data.RowHeadersWidth = 50;
            this.Data.Size = new System.Drawing.Size(350, 250);
            this.Data.TabIndex = 0;
            // 
            // Day
            // 
            this.Day.HeaderText = "Dzień";
            this.Day.Name = "Day";
            // 
            // APS
            // 
            this.APS.HeaderText = "Przybliżona liczebność populacji";
            this.APS.Name = "APS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(446, 70);
            this.label1.MinimumSize = new System.Drawing.Size(0, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Początkowa liczba organizmów:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(446, 108);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dzienny Przyrost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(446, 143);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Liczba Dni:";
            // 
            // INOO
            // 
            this.INOO.Location = new System.Drawing.Point(659, 70);
            this.INOO.Name = "INOO";
            this.INOO.Size = new System.Drawing.Size(100, 20);
            this.INOO.TabIndex = 4;
            // 
            // DailyGrow
            // 
            this.DailyGrow.Location = new System.Drawing.Point(659, 108);
            this.DailyGrow.Name = "DailyGrow";
            this.DailyGrow.Size = new System.Drawing.Size(100, 20);
            this.DailyGrow.TabIndex = 5;
            this.DailyGrow.TextChanged += new System.EventHandler(this.DailyGrow_TextChanged);
            // 
            // Days
            // 
            this.Days.Location = new System.Drawing.Point(659, 143);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(100, 20);
            this.Days.TabIndex = 6;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(449, 209);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 7;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(659, 209);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 8;
            this.Quit.Text = "Zakończ";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(550, 209);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.DailyGrow);
            this.Controls.Add(this.INOO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn APS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox INOO;
        private System.Windows.Forms.TextBox DailyGrow;
        private System.Windows.Forms.TextBox Days;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button SaveButton;
    }
}

