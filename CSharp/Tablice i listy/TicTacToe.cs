using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Tablice_i_listy
{
    public partial class TicTacToe : Form
    {
        const string XPath = @"P:\Visual Studio Programy\CSharp\Tablice i listy\TX.png";
        const string OPath = @"P:\Visual Studio Programy\CSharp\Tablice i listy\TO.png";
        bool XisActive = true;
        int moves = 0;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void clearBoard()
        {
           foreach(PictureBox p in BoardBox.Controls)
            {
                p.Image = null;
                p.Enabled = true;
                p.Tag = "";
            }
           //Reseting values
                moves = 0;
                XisActive = true;
        }

        private void Log(string message)
        {
            InfoLabel.Text = message;
        }

        private void checkWin()
        {
            bool winner = false;

            //Horizontal
            if ((A1.Tag == A2.Tag) && (A2.Tag == A3.Tag) &&(!A1.Enabled))
                winner = true;
            else if ((B1.Tag == A2.Tag) && (B2.Tag == B3.Tag) && (!B1.Enabled))
                winner = true;
            else if((C1.Tag == C2.Tag) && (C2.Tag == C3.Tag) && (!C1.Enabled))
                winner = true;

            //Vertical
            else if((A1.Tag == B1.Tag) && (B1.Tag == C1.Tag) && (!A1.Enabled))
                winner = true;
            else if((A2.Tag == B2.Tag) && (B2.Tag == C2.Tag) && (!A2.Enabled))
                winner = true;
            else if((A3.Tag == B3.Tag) && (B3.Tag == C3.Tag) && (!A3.Enabled))
                winner = true;

            //Diagonal
            else if((A1.Tag == B2.Tag) && (B2.Tag == C3.Tag) && (!A1.Enabled))
                winner = true;
            else if((A3.Tag == B2.Tag) && (B2.Tag == C1.Tag) && (!C1.Enabled))
                winner = true;
            else if(moves==9)
            {
                Log("Draw ! No one won !");
                LockButtons();
            }

            if(winner)
            {
                if (XisActive)
                {
                    Log("X won the game !");
                    LockButtons();
                }
                else
                {
                    Log("O won the game !");
                    LockButtons();
                } 
            }

        }

        private void LockButtons()
        {
            foreach (PictureBox p in BoardBox.Controls)
            {
                p.Enabled = false;
            }
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
           
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            clearBoard();
            Log("TicTacToe");
        }

        private void Box_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            if (XisActive)
            {
                p.Image = Image.FromFile(XPath);
                p.Enabled = false;
                p.Tag = "X";
                moves++;
                checkWin();
                XisActive = !XisActive;
            }
            else
            {
                p.Image = Image.FromFile(OPath);
                p.Enabled = false;
                p.Tag = "O";
                moves++;
                checkWin();
                XisActive = true;
            }

        }

    }
}


