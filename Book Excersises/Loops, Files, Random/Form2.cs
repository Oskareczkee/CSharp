using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace B__Pętle__Pliki_i_losowość
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            StreamWriter writer;

            if(saveFile.ShowDialog()==DialogResult.OK)
            {
                writer = File.CreateText(saveFile.FileName);
                foreach(var number in GeneratedNumbers.Items)
                {
                    writer.WriteLine(number);
                }
                writer.Close();
            }
        }

        private void GeneratedNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            try
            {
                for(int x=1;x<=int.Parse(NumberCount.Text);x++)
            GeneratedNumbers.Items.Add(x+"->"+rand.Next(int.Parse(Minimum.Text), int.Parse(Maximum.Text) + 1));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {
            StreamReader reader;

            if(OpenFile.ShowDialog()==DialogResult.OK)
            {
                reader = File.OpenText(OpenFile.FileName);
                while (!reader.EndOfStream)
                    GeneratedNumbers.Items.Add(reader.ReadLine());
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            GeneratedNumbers.Items.Clear();
        }
    }
}
