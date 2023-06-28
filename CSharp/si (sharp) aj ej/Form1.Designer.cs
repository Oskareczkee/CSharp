
namespace si__sharp__aj_ej
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Obrazek = new System.Windows.Forms.PictureBox();
            this.kochamMcDonald = new System.Windows.Forms.Button();
            this.ProgramExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // Obrazek
            // 
            this.Obrazek.Image = ((System.Drawing.Image)(resources.GetObject("Obrazek.Image")));
            this.Obrazek.Location = new System.Drawing.Point(33, 12);
            this.Obrazek.Name = "Obrazek";
            this.Obrazek.Size = new System.Drawing.Size(664, 425);
            this.Obrazek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Obrazek.TabIndex = 0;
            this.Obrazek.TabStop = false;
            this.Obrazek.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kochamMcDonald
            // 
            this.kochamMcDonald.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.kochamMcDonald.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kochamMcDonald.BackgroundImage")));
            this.kochamMcDonald.ForeColor = System.Drawing.Color.Fuchsia;
            this.kochamMcDonald.Location = new System.Drawing.Point(98, 471);
            this.kochamMcDonald.Name = "kochamMcDonald";
            this.kochamMcDonald.Size = new System.Drawing.Size(184, 60);
            this.kochamMcDonald.TabIndex = 1;
            this.kochamMcDonald.Text = "Wyznaj Miłość McDonald";
            this.kochamMcDonald.UseVisualStyleBackColor = false;
            this.kochamMcDonald.Click += new System.EventHandler(this.kochamMcDonald_Click);
            // 
            // ProgramExit
            // 
            this.ProgramExit.BackColor = System.Drawing.Color.White;
            this.ProgramExit.Location = new System.Drawing.Point(407, 471);
            this.ProgramExit.Name = "ProgramExit";
            this.ProgramExit.Size = new System.Drawing.Size(175, 59);
            this.ProgramExit.TabIndex = 2;
            this.ProgramExit.Text = "Nie jestem Gejem, wyłączaj ten program";
            this.ProgramExit.UseVisualStyleBackColor = false;
            this.ProgramExit.Click += new System.EventHandler(this.ProgramExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 559);
            this.Controls.Add(this.ProgramExit);
            this.Controls.Add(this.kochamMcDonald);
            this.Controls.Add(this.Obrazek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Obrazek;
        private System.Windows.Forms.Button kochamMcDonald;
        private System.Windows.Forms.Button ProgramExit;
    }
}

