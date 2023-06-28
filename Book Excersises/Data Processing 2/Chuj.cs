using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Przetwarzanie_danych_numero_dos
{
    public partial class Chuj : Form
    {
        //<methods>
        private string ConvertText(string text)
        {
            string[] words = text.Split(' ');

            for(int x=0;x<words.Length;x++)
            {
                char firstLetter = words[x][0];

                //Replacing fisrt letter with last and vice versa
                words[x] = words[x].Remove(0,1);
                words[x] = words[x].Insert(words[x].Length, firstLetter.ToString());

                words[x]=words[x].Insert(words[x].Length, "AY ");
            }

            string output=String.Empty;

            //build output string
            for(int x=0;x<words.Length;x++)
            {
                output += words[x];
            }

            output.Trim();
            return output;
        }


       //</methods>


      //Windows Forms Controls
        public Chuj()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Text.Clear();
            ConvertedText.Clear();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            ConvertedText.Text = ConvertText(Text.Text);
        }
    }
}
