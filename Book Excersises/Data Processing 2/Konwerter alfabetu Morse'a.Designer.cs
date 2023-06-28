
namespace Przetwarzanie_danych_numero_dos
{
    partial class Program2
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
            this.TextToTranslate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TranslatedText = new System.Windows.Forms.TextBox();
            this.TranslationType = new System.Windows.Forms.Label();
            this.ReverseButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Translate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextToTranslate
            // 
            this.TextToTranslate.Location = new System.Drawing.Point(12, 73);
            this.TextToTranslate.MinimumSize = new System.Drawing.Size(300, 300);
            this.TextToTranslate.Multiline = true;
            this.TextToTranslate.Name = "TextToTranslate";
            this.TextToTranslate.Size = new System.Drawing.Size(300, 300);
            this.TextToTranslate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text to translate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(672, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Translated Text";
            // 
            // TranslatedText
            // 
            this.TranslatedText.Location = new System.Drawing.Point(488, 73);
            this.TranslatedText.MinimumSize = new System.Drawing.Size(300, 300);
            this.TranslatedText.Multiline = true;
            this.TranslatedText.Name = "TranslatedText";
            this.TranslatedText.ReadOnly = true;
            this.TranslatedText.Size = new System.Drawing.Size(300, 300);
            this.TranslatedText.TabIndex = 2;
            // 
            // TranslationType
            // 
            this.TranslationType.AutoSize = true;
            this.TranslationType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TranslationType.Location = new System.Drawing.Point(348, 179);
            this.TranslationType.Name = "TranslationType";
            this.TranslationType.Size = new System.Drawing.Size(106, 20);
            this.TranslationType.TabIndex = 4;
            this.TranslationType.Text = "Morse to Text";
            // 
            // ReverseButton
            // 
            this.ReverseButton.Location = new System.Drawing.Point(363, 268);
            this.ReverseButton.Name = "ReverseButton";
            this.ReverseButton.Size = new System.Drawing.Size(75, 23);
            this.ReverseButton.TabIndex = 5;
            this.ReverseButton.Text = "Reverse";
            this.ReverseButton.UseVisualStyleBackColor = true;
            this.ReverseButton.Click += new System.EventHandler(this.ReverseButton_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(363, 297);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Translate
            // 
            this.Translate.Location = new System.Drawing.Point(363, 210);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(75, 23);
            this.Translate.TabIndex = 7;
            this.Translate.Text = "Translate";
            this.Translate.UseVisualStyleBackColor = true;
            this.Translate.Click += new System.EventHandler(this.Translate_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(363, 239);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ReverseButton);
            this.Controls.Add(this.TranslationType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TranslatedText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextToTranslate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextToTranslate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TranslatedText;
        private System.Windows.Forms.Label TranslationType;
        private System.Windows.Forms.Button ReverseButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Translate;
        private System.Windows.Forms.Button Clear;
    }
}

