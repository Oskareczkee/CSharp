
namespace Przetwarzanie_danych_numero_dos
{
    partial class Chuj
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
            this.Text = new System.Windows.Forms.TextBox();
            this.ConvertedText = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(12, 75);
            this.Text.MinimumSize = new System.Drawing.Size(300, 200);
            this.Text.Multiline = true;
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(300, 200);
            this.Text.TabIndex = 0;
            // 
            // ConvertedText
            // 
            this.ConvertedText.Location = new System.Drawing.Point(488, 75);
            this.ConvertedText.MinimumSize = new System.Drawing.Size(300, 200);
            this.ConvertedText.Multiline = true;
            this.ConvertedText.Name = "ConvertedText";
            this.ConvertedText.ReadOnly = true;
            this.ConvertedText.Size = new System.Drawing.Size(300, 200);
            this.ConvertedText.TabIndex = 1;
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(359, 165);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(75, 23);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(359, 194);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(359, 223);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Chuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.ConvertedText);
            this.Controls.Add(this.Text);
            this.Name = "Chuj";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text;
        private System.Windows.Forms.TextBox ConvertedText;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
    }
}