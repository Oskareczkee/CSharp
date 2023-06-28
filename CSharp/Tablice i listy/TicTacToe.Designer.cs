
namespace Tablice_i_listy
{
    partial class TicTacToe
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
            this.A1 = new System.Windows.Forms.PictureBox();
            this.A2 = new System.Windows.Forms.PictureBox();
            this.A3 = new System.Windows.Forms.PictureBox();
            this.B3 = new System.Windows.Forms.PictureBox();
            this.B2 = new System.Windows.Forms.PictureBox();
            this.B1 = new System.Windows.Forms.PictureBox();
            this.C1 = new System.Windows.Forms.PictureBox();
            this.C2 = new System.Windows.Forms.PictureBox();
            this.C3 = new System.Windows.Forms.PictureBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.NewGame = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.BoardBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C3)).BeginInit();
            this.BoardBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.SystemColors.Window;
            this.A1.Location = new System.Drawing.Point(29, 30);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(80, 80);
            this.A1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A1.TabIndex = 0;
            this.A1.TabStop = false;
            this.A1.Click += new System.EventHandler(this.Box_Click);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.SystemColors.Window;
            this.A2.Location = new System.Drawing.Point(153, 30);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(80, 80);
            this.A2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A2.TabIndex = 1;
            this.A2.TabStop = false;
            this.A2.Click += new System.EventHandler(this.Box_Click);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.SystemColors.Window;
            this.A3.Location = new System.Drawing.Point(281, 30);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(80, 80);
            this.A3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A3.TabIndex = 2;
            this.A3.TabStop = false;
            this.A3.Click += new System.EventHandler(this.Box_Click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.SystemColors.Window;
            this.B3.Location = new System.Drawing.Point(281, 136);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(80, 80);
            this.B3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B3.TabIndex = 3;
            this.B3.TabStop = false;
            this.B3.Click += new System.EventHandler(this.Box_Click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.SystemColors.Window;
            this.B2.Location = new System.Drawing.Point(153, 136);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(80, 80);
            this.B2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B2.TabIndex = 4;
            this.B2.TabStop = false;
            this.B2.Click += new System.EventHandler(this.Box_Click);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.SystemColors.Window;
            this.B1.Location = new System.Drawing.Point(29, 136);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(80, 80);
            this.B1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B1.TabIndex = 5;
            this.B1.TabStop = false;
            this.B1.Click += new System.EventHandler(this.Box_Click);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.SystemColors.Window;
            this.C1.Location = new System.Drawing.Point(29, 249);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(80, 80);
            this.C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C1.TabIndex = 6;
            this.C1.TabStop = false;
            this.C1.Click += new System.EventHandler(this.Box_Click);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.SystemColors.Window;
            this.C2.Location = new System.Drawing.Point(153, 249);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(80, 80);
            this.C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C2.TabIndex = 7;
            this.C2.TabStop = false;
            this.C2.Click += new System.EventHandler(this.Box_Click);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.SystemColors.Window;
            this.C3.Location = new System.Drawing.Point(281, 249);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(80, 80);
            this.C3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C3.TabIndex = 8;
            this.C3.TabStop = false;
            this.C3.Click += new System.EventHandler(this.Box_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.BackColor = System.Drawing.SystemColors.Window;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InfoLabel.Location = new System.Drawing.Point(183, 395);
            this.InfoLabel.MinimumSize = new System.Drawing.Size(300, 30);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(300, 30);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "TicTacToe";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(234, 455);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(75, 23);
            this.NewGame.TabIndex = 2;
            this.NewGame.Text = "&New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(357, 455);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // BoardBox
            // 
            this.BoardBox.Controls.Add(this.A1);
            this.BoardBox.Controls.Add(this.A2);
            this.BoardBox.Controls.Add(this.A3);
            this.BoardBox.Controls.Add(this.B1);
            this.BoardBox.Controls.Add(this.C2);
            this.BoardBox.Controls.Add(this.C3);
            this.BoardBox.Controls.Add(this.B2);
            this.BoardBox.Controls.Add(this.B3);
            this.BoardBox.Controls.Add(this.C1);
            this.BoardBox.Location = new System.Drawing.Point(142, 12);
            this.BoardBox.Name = "BoardBox";
            this.BoardBox.Size = new System.Drawing.Size(382, 346);
            this.BoardBox.TabIndex = 0;
            this.BoardBox.TabStop = false;
            this.BoardBox.Text = "Board";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(654, 508);
            this.Controls.Add(this.BoardBox);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.InfoLabel);
            this.Name = "TicTacToe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C3)).EndInit();
            this.BoardBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox A1;
        private System.Windows.Forms.PictureBox A2;
        private System.Windows.Forms.PictureBox A3;
        private System.Windows.Forms.PictureBox B3;
        private System.Windows.Forms.PictureBox B2;
        private System.Windows.Forms.PictureBox B1;
        private System.Windows.Forms.PictureBox C1;
        private System.Windows.Forms.PictureBox C2;
        private System.Windows.Forms.PictureBox C3;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.GroupBox BoardBox;
    }
}